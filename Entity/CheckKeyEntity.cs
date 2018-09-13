using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class CheckKeyEntity
    {
        public string IDCPU { get; set; }
        public Int64 SoPhutConLai { get; set; }
        public string SoPhutConLaiMaHoa { get; set; }
        public string DaMuaFull { get; set; }// 20 ki tu + '$' + bool (da full) + '$' + 7 ki tu
        public Int32 SoLanDaUpdate { get; set; }
        public String SoLanDaUpdateMaHoa { get; set; }
    }
}
