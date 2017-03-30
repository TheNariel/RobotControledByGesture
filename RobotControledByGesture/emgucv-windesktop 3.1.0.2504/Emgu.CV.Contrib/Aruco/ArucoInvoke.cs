//----------------------------------------------------------------------------
//  Copyright (C) 2004-2016 by EMGU Corporation. All rights reserved.       
//----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using Emgu.CV.Structure;
using Emgu.CV.Text;
using Emgu.CV.Util;
using Emgu.Util;
using System.Diagnostics;
using System.Drawing;
using Emgu.CV.CvEnum;

namespace Emgu.CV.Aruco
{
   /// <summary>
   /// Entry points for the cv::aruco functions.
   /// </summary>
   public static partial class ArucoInvoke
   {
      static ArucoInvoke()
      {
         CvInvoke.CheckLibraryLoaded();
      }

      /// <summary>
      /// Draw a canonical marker image.
      /// </summary>
      /// <param name="dict">dictionary of markers indicating the type of markers</param>
      /// <param name="id">identifier of the marker that will be returned. It has to be a valid id in the specified dictionary.</param>
      /// <param name="sidePixels">size of the image in pixels</param>
      /// <param name="img">output image with the marker</param>
      /// <param name="borderBits">width of the marker border.</param>
      public static void DrawMarker(Dictionary dict, int id, int sidePixels, IOutputArray img, int borderBits = 1)
      {
         using (OutputArray oaImg = img.GetOutputArray())
            cveArucoDrawMarker(dict, id, sidePixels, oaImg, borderBits);
      }
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void cveArucoDrawMarker(IntPtr dictionary, int id, int sidePixels, IntPtr img, int borderBits);


      /// <summary>
      /// Performs marker detection in the input image. Only markers included in the specific dictionary are searched. For each detected marker, it returns the 2D position of its corner in the image and its corresponding identifier. Note that this function does not perform pose estimation.
      /// </summary>
      /// <param name="image">input image</param>
      /// <param name="dict">indicates the type of markers that will be searched</param>
      /// <param name="corners">	vector of detected marker corners. For each marker, its four corners are provided, (e.g VectorOfVectorOfPointF ). For N detected markers, the dimensions of this array is Nx4. The order of the corners is clockwise.</param>
      /// <param name="ids">vector of identifiers of the detected markers. The identifier is of type int (e.g. VectorOfInt). For N detected markers, the size of ids is also N. The identifiers have the same order than the markers in the imgPoints array.</param>
      /// <param name="parameters">marker detection parameters</param>
      /// <param name="rejectedImgPoints">contains the imgPoints of those squares whose inner code has not a correct codification. Useful for debugging purposes.</param>
      public static void DetectMarkers(
         IInputArray image, Dictionary dict, IOutputArrayOfArrays corners,
         IOutputArray ids, DetectorParameters parameters,
         IOutputArrayOfArrays rejectedImgPoints = null
         )
      {
         using (InputArray iaImage = image.GetInputArray())
         using (OutputArray oaCorners = corners.GetOutputArray())
         using (OutputArray oaIds = ids.GetOutputArray())
         using (OutputArray oaRejectedImgPoints = rejectedImgPoints != null ? rejectedImgPoints.GetOutputArray() : OutputArray.GetEmpty())
         {
            cveArucoDetectMarkers(iaImage, dict, oaCorners, oaIds, ref parameters, oaRejectedImgPoints);
         }
      }
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void cveArucoDetectMarkers(IntPtr image, IntPtr dictionary, IntPtr corners,
         IntPtr ids, ref DetectorParameters parameters,
         IntPtr rejectedImgPoints);

      /// <summary>
      /// Given the pose estimation of a marker or board, this function draws the axis of the world coordinate system, i.e. the system centered on the marker/board. Useful for debugging purposes.
      /// </summary>
      /// <param name="image">input/output image. It must have 1 or 3 channels. The number of channels is not altered.</param>
      /// <param name="cameraMatrix">input 3x3 floating-point camera matrix</param>
      /// <param name="distCoeffs">vector of distortion coefficients (k1,k2,p1,p2[,k3[,k4,k5,k6],[s1,s2,s3,s4]]) of 4, 5, 8 or 12 elements</param>
      /// <param name="rvec">rotation vector of the coordinate system that will be drawn.</param>
      /// <param name="tvec">translation vector of the coordinate system that will be drawn.</param>
      /// <param name="length">length of the painted axis in the same unit than tvec (usually in meters)</param>
      public static void DrawAxis(
         IInputOutputArray image, IInputArray cameraMatrix, IInputArray distCoeffs,
         IInputArray rvec, IInputArray tvec, float length)
      {
         using (InputOutputArray ioaImage = image.GetInputOutputArray())
         using (InputArray iaCameraMatrix = cameraMatrix.GetInputArray())
         using (InputArray iaDistCoeffs = distCoeffs.GetInputArray())
         using (InputArray iaRvec = rvec.GetInputArray())
         using (InputArray iaTvec = tvec.GetInputArray())
         {
            cveArucoDrawAxis(ioaImage, iaCameraMatrix, iaDistCoeffs, iaRvec, iaTvec, length);
         }
      }
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void cveArucoDrawAxis(IntPtr image, IntPtr cameraMatrix, IntPtr distCoeffs, IntPtr rvec, IntPtr tvec, float length);

      /// <summary>
      /// This function receives the detected markers and returns their pose estimation respect to the camera individually. So for each marker, one rotation and translation vector is returned. The returned transformation is the one that transforms points from each marker coordinate system to the camera coordinate system. The marker corrdinate system is centered on the middle of the marker, with the Z axis perpendicular to the marker plane. The coordinates of the four corners of the marker in its own coordinate system are: (-markerLength/2, markerLength/2, 0), (markerLength/2, markerLength/2, 0), (markerLength/2, -markerLength/2, 0), (-markerLength/2, -markerLength/2, 0)
      /// </summary>
      /// <param name="corners">vector of already detected markers corners. For each marker, its four corners are provided, (e.g VectorOfVectorOfPointF ). For N detected markers, the dimensions of this array should be Nx4. The order of the corners should be clockwise.</param>
      /// <param name="markerLength">the length of the markers' side. The returning translation vectors will be in the same unit. Normally, unit is meters.</param>
      /// <param name="cameraMatrix">input 3x3 floating-point camera matrix</param>
      /// <param name="distCoeffs">vector of distortion coefficients (k1,k2,p1,p2[,k3[,k4,k5,k6],[s1,s2,s3,s4]]) of 4, 5, 8 or 12 elements</param>
      /// <param name="rvecs">array of output rotation vectors. Each element in rvecs corresponds to the specific marker in imgPoints.</param>
      /// <param name="tvecs">array of output translation vectors (e.g. VectorOfPoint3D32F ). Each element in tvecs corresponds to the specific marker in imgPoints.</param>
      public static void EstimatePoseSingleMarkers(IInputArrayOfArrays corners, float markerLength,
         IInputArray cameraMatrix, IInputArray distCoeffs,
         IOutputArrayOfArrays rvecs, IOutputArrayOfArrays tvecs)
      {
         using (InputArray iaCorners = corners.GetInputArray())
         using (InputArray iaCameraMatrix = cameraMatrix.GetInputArray())
         using (InputArray iaDistCoeffs = distCoeffs.GetInputArray())
         using (OutputArray oaRvecs = rvecs.GetOutputArray())
         using (OutputArray oaTvecs = tvecs.GetOutputArray())
         {
            cveArucoEstimatePoseSingleMarkers(iaCorners, markerLength, iaCameraMatrix, iaDistCoeffs, oaRvecs, oaTvecs);
         }
      }
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void cveArucoEstimatePoseSingleMarkers(IntPtr corners, float markerLength,
         IntPtr cameraMatrix, IntPtr distCoeffs,
         IntPtr rvecs, IntPtr tvecs);

      /// <summary>
      /// Refind not detected markers based on the already detected and the board layout.
      /// </summary>
      /// <param name="image">Input image</param>
      /// <param name="board">Layout of markers in the board.</param>
      /// <param name="detectedCorners">Vector of already detected marker corners.</param>
      /// <param name="detectedIds">Vector of already detected marker identifiers.</param>
      /// <param name="rejectedCorners">Vector of rejected candidates during the marker detection process</param>
      /// <param name="cameraMatrix">Optional input 3x3 floating-point camera matrix </param>
      /// <param name="distCoeffs">Optional vector of distortion coefficients (k1,k2,p1,p2[,k3[,k4,k5,k6],[s1,s2,s3,s4]]) of 4, 5, 8 or 12 elements</param>
      /// <param name="minRepDistance">Minimum distance between the corners of the rejected candidate and the reprojected marker in order to consider it as a correspondence. (default 10)</param>
      /// <param name="errorCorrectionRate">Rate of allowed erroneous bits respect to the error correction capability of the used dictionary. -1 ignores the error correction step. (default 3)</param>
      /// <param name="checkAllOrders">Consider the four posible corner orders in the rejectedCorners array. If it set to false, only the provided corner order is considered (default true).</param>
      /// <param name="recoveredIdxs">Optional array to returns the indexes of the recovered candidates in the original rejectedCorners array.</param>
      /// <param name="parameters">marker detection parameters</param>
      public static void RefineDetectedMarkers(
         IInputArray image, IBoard board, IInputOutputArray detectedCorners,
         IInputOutputArray detectedIds, IInputOutputArray rejectedCorners,
         IInputArray cameraMatrix, IInputArray distCoeffs,
         float minRepDistance, float errorCorrectionRate,
         bool checkAllOrders,
         IOutputArray recoveredIdxs, DetectorParameters parameters)
      {
         using (InputArray iaImage = image.GetInputArray())
         using (InputOutputArray ioaDetectedCorners = detectedCorners.GetInputOutputArray())
         using (InputOutputArray ioaDetectedIds = detectedIds.GetInputOutputArray())
         using (InputOutputArray ioaRejectedCorners = rejectedCorners.GetInputOutputArray())
         using (InputArray iaCameraMatrix = cameraMatrix == null ? InputArray.GetEmpty() : cameraMatrix.GetInputArray())
         using (InputArray iaDistCoeffs = distCoeffs == null ? InputArray.GetEmpty() : distCoeffs.GetInputArray())
         using (
            OutputArray oaRecovervedIdx = recoveredIdxs == null
               ? OutputArray.GetEmpty()
               : recoveredIdxs.GetOutputArray())
         {
            cveArucoRefineDetectedMarkers(iaImage, board.BoardPtr, ioaDetectedCorners, ioaDetectedIds, ioaRejectedCorners,
               iaCameraMatrix, iaDistCoeffs, minRepDistance, errorCorrectionRate, checkAllOrders, oaRecovervedIdx, ref parameters);
         }
      }
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void cveArucoRefineDetectedMarkers(
         IntPtr image, IntPtr board, IntPtr detectedCorners,
         IntPtr detectedIds, IntPtr rejectedCorners,
         IntPtr cameraMatrix, IntPtr distCoeffs,
         float minRepDistance, float errorCorrectionRate,
         [MarshalAs(CvInvoke.BoolMarshalType)]
         bool checkAllOrders,
         IntPtr ecoveredIdxs, ref DetectorParameters parameters);

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void cveArucoDetectorParametersGetDefault(ref DetectorParameters parameters);

      /// <summary>
      /// Draw detected markers in image.
      /// </summary>
      /// <param name="image">Input/output image. It must have 1 or 3 channels. The number of channels is not altered.</param>
      /// <param name="corners">Positions of marker corners on input image. (e.g std::vector&lt;std::vector&lt;cv::Point2f&gt; &gt; ). For N detected markers, the dimensions of this array should be Nx4. The order of the corners should be clockwise.</param>
      /// <param name="ids">Vector of identifiers for markers in markersCorners . Optional, if not provided, ids are not painted.</param>
      /// <param name="borderColor">Volor of marker borders. Rest of colors (text color and first corner color) are calculated based on this one to improve visualization.</param>
      public static void DrawDetectedMarkers(
         IInputOutputArray image, IInputArray corners, IInputArray ids,
         MCvScalar borderColor)
      {
         using (InputOutputArray ioaImage = image.GetInputOutputArray())
         using (InputArray iaCorners = corners.GetInputArray())
         using (InputArray iaIds = ids.GetInputArray())
         {
            cveArucoDrawDetectedMarkers(ioaImage, iaCorners, iaIds, ref borderColor);
         }
      }

      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern void cveArucoDrawDetectedMarkers(
         IntPtr image, IntPtr corners,
         IntPtr ids, ref MCvScalar borderColor);

      /// <summary>
      /// Calibrate a camera using aruco markers.
      /// </summary>
      /// <param name="corners">Vector of detected marker corners in all frames. The corners should have the same format returned by detectMarkers</param>
      /// <param name="ids">List of identifiers for each marker in corners</param>
      /// <param name="counter">Number of markers in each frame so that corners and ids can be split</param>
      /// <param name="board">Marker Board layout</param>
      /// <param name="imageSize">Size of the image used only to initialize the intrinsic camera matrix.</param>
      /// <param name="cameraMatrix">Output 3x3 floating-point camera matrix. </param>
      /// <param name="distCoeffs">Output vector of distortion coefficients (k1,k2,p1,p2[,k3[,k4,k5,k6],[s1,s2,s3,s4]]) of 4, 5, 8 or 12 elements</param>
      /// <param name="rvecs">Output vector of rotation vectors (see Rodrigues ) estimated for each board view (e.g. std::vector&lt;cv::Mat&gt;>). That is, each k-th rotation vector together with the corresponding k-th translation vector (see the next output parameter description) brings the board pattern from the model coordinate space (in which object points are specified) to the world coordinate space, that is, a real position of the board pattern in the k-th pattern view (k=0.. M -1).</param>
      /// <param name="tvecs">Output vector of translation vectors estimated for each pattern view.</param>
      /// <param name="flags">Flags Different flags for the calibration process</param>
      /// <param name="criteria">Termination criteria for the iterative optimization algorithm.</param>
      /// <returns>The final re-projection error.</returns>
      public static  double CalibrateCameraAruco(
         IInputArray corners, IInputArray ids, IInputArray counter, IBoard board, Size imageSize,
         IInputOutputArray cameraMatrix, IInputOutputArray distCoeffs, IOutputArray rvecs, IOutputArray tvecs,
         CalibType flags, MCvTermCriteria criteria)
      {
         using (InputArray iaCorners = corners.GetInputArray())
         using (InputArray iaIds = ids.GetInputArray())
         using (InputArray iaCounter = counter.GetInputArray())
         using (InputOutputArray ioaCameraMatrix = cameraMatrix.GetInputOutputArray())
         using (InputOutputArray ioaDistCoeffs = distCoeffs.GetInputOutputArray())
         using (OutputArray oaRvecs = rvecs == null ? OutputArray.GetEmpty() : rvecs.GetOutputArray())
         using (OutputArray oaTvecs = tvecs == null ? OutputArray.GetEmpty() : tvecs.GetOutputArray())
         {
            return cveArucoCalibrateCameraAruco(iaCorners, iaIds, iaCounter, board.BoardPtr, ref imageSize,
               ioaCameraMatrix, ioaDistCoeffs, oaRvecs, oaTvecs, flags, ref criteria);
         }
      }
      
      [DllImport(CvInvoke.ExternLibrary, CallingConvention = CvInvoke.CvCallingConvention)]
      internal static extern double cveArucoCalibrateCameraAruco(
         IntPtr corners, IntPtr ids, IntPtr counter, IntPtr board,
         ref Size imageSize, IntPtr cameraMatrix, IntPtr distCoeffs,
         IntPtr rvecs, IntPtr tvecs, CalibType flags,
         ref MCvTermCriteria criteria);
   }
}