
using Entity;
using System;
namespace Business
{
	public class InformationBO
	{
		public static InformationEntity Select()
		{
			return DataAccess.InformationDA.Select();
		}

		public static Int32 UpdatePhieuChotKetGanNhat(InformationEntity information)
		{
			return DataAccess.InformationDA.UpdatePhieuChotKetGanNhat(information);
		}
	}
}
