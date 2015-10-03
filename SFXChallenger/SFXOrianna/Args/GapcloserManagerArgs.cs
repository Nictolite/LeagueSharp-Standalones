#region License

/*
 Copyright 2014 - 2015 Nikita Bernthaler
 GapcloserManagerArgs.cs is part of SFXOrianna.

 SFXOrianna is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation, either version 3 of the License, or
 (at your option) any later version.

 SFXOrianna is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 GNU General Public License for more details.

 You should have received a copy of the GNU General Public License
 along with SFXOrianna. If not, see <http://www.gnu.org/licenses/>.
*/

#endregion License

#region

using System;
using LeagueSharp;
using SharpDX;

#endregion

namespace SFXOrianna.Args
{
    public class GapcloserManagerArgs : EventArgs
    {
        public GapcloserManagerArgs(string uniqueId, Obj_AI_Hero hero, Vector3 start, Vector3 end, float endTime)
        {
            UniqueId = uniqueId;
            Hero = hero;
            Start = start;
            End = end;
            EndTime = endTime;
        }

        public float EndTime { get; set; }
        public string UniqueId { get; set; }
        public Obj_AI_Hero Hero { get; private set; }
        public Vector3 Start { get; private set; }
        public Vector3 End { get; private set; }
    }
}