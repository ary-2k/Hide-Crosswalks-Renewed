namespace HideTMPECrosswalksRenewed.Utils {
    using HideCrosswalksRenewed;
    public static class PrephabUtils {
        public static bool CanHideMarkings(NetInfo info) => NetInfoExt.GetCanHideMarkings(info);
    }    
}
