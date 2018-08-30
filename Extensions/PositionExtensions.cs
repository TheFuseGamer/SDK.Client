﻿using CitizenFX.Core;
using NFive.SDK.Core.Models;

namespace NFive.SDK.Client.Extensions
{
	public static class PositionExtentions
	{
		public static Vector3 ToVector3(this Position pos) => new Vector3
		{
			X = pos.X,
			Y = pos.Y,
			Z = pos.Z
		};
	}
}