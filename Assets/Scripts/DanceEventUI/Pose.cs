using System.Collections.Generic;

namespace DanceEvent
{
	public enum Pose
	{
		Splits,
		Cool
	}

	public class PoseOrder
	{
		public List<Limb> LimbRotationOrder;

		public PoseOrder(Pose pose)
		{
			switch(pose)
			{
				case Pose.Splits:
					LimbRotationOrder = new List<Limb>()
					{
						Limb.ArmRight,
						Limb.LegRight,
						Limb.LegLeft,
						Limb.ArmLeft
					};
					break;
				case Pose.Cool:
					LimbRotationOrder = new List<Limb>()
					{
						Limb.ArmLeft,
						Limb.LegRight,
						Limb.LegLeft,
						Limb.ArmRight
					};
					break;
				default:
					break;
			}
		}
	}
}
