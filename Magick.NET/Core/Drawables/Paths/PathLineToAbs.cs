//=================================================================================================
// Copyright 2013-2016 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in 
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using System.Collections.Generic;
using ImageMagick.Drawables;

namespace ImageMagick
{
  ///<summary>
  /// Draws a line path from the current point to the given coordinate using absolute coordinates.
  /// The coordinate then becomes the new current point.
  ///</summary>
  public sealed class PathLineToAbs : IPath
  {
    private PointDCoordinates _Coordinates;

    void IPath.Draw(IDrawingWand wand)
    {
      if (wand != null)
        wand.PathLineToAbs(_Coordinates.ToList());
    }

    ///<summary>
    /// Initializes a new instance of the PathLineToAbs class.
    ///</summary>
    ///<param name="coordinates">The coordinates to use.</param>
    public PathLineToAbs(params PointD[] coordinates)
    {
      _Coordinates = new PointDCoordinates(coordinates);
    }

    ///<summary>
    /// Initializes a new instance of the PathLineToAbs class.
    ///</summary>
    ///<param name="coordinates">The coordinates to use.</param>
    public PathLineToAbs(IEnumerable<PointD> coordinates)
    {
      _Coordinates = new PointDCoordinates(coordinates);
    }
  }
}