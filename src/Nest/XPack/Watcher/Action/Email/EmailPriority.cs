﻿using System.Runtime.Serialization;


namespace Nest
{

	public enum EmailPriority
	{
		[EnumMember(Value = "lowest")]
		Lowest,

		[EnumMember(Value = "low")]
		Low,

		[EnumMember(Value = "normal")]
		Normal,

		[EnumMember(Value = "high")]
		High,

		[EnumMember(Value = "highest")]
		Highest
	}
}
