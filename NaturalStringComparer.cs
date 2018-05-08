using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CovertManga
{
    [SuppressUnmanagedCodeSecurity]
    internal static class SafeNativeMethods
    {
        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
        public static extern int StrCmpLogicalW(string psz1, string psz2);
    }
    public class NaturalStringComparer : IComparer<string>
    {
        private readonly int modifier = 1;

        public NaturalStringComparer() : this(false) { }
        public NaturalStringComparer(bool descending)
        {
            if (descending) modifier = -1;
        }

        public int Compare(string a, string b)
        {
            return SafeNativeMethods.StrCmpLogicalW(a ?? "", b ?? "") * modifier;
        }
    }
}
