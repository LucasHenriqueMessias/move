using System;
using System.Collections.Generic;

namespace oraclebam.Models
{
    public partial class MvSysSefExchangeFile
    {
        public string SefCompany { get; set; } = null!;
        public long SefId { get; set; }
        public string SefOperation { get; set; } = null!;
        public string SefSourceHost { get; set; } = null!;
        public string SefSourceDir { get; set; } = null!;
        public string SefSourceFile { get; set; } = null!;
        public string SefDestHost { get; set; } = null!;
        public string SefDestDir { get; set; } = null!;
        public string? SefDestFile { get; set; }
        public string? SefBackupDir { get; set; }
        public string? SefShare { get; set; }
        public string? SefDestShare { get; set; }
        public string SefDeleteSource { get; set; } = null!;
        public string SefAppend { get; set; } = null!;
        public string SefUserAlt { get; set; } = null!;
        public DateTime? SefDateAlt { get; set; }
        public string SefSourceFtpUser { get; set; } = null!;
        public string SefDestFtpUser { get; set; } = null!;
        public string SefModule { get; set; } = null!;
    }
}
