namespace DeepPolymer.Constants;

public static class ColorConstant
{
    // 1 for Santej, 2 for Hajipur
    public const int BranchFlag = 1;

    // Santej Colors
    public const string SantejPrimaryColor = "#ff0000";
    public const string SantejPrimaryBg = "#FFE5E5";
    public const string SantejPageBg = "#F2F2F2";

    // Hajipur Colors
    public const string HajipurPrimaryColor = "#0405AB";
    public const string HajipurPrimaryBg = "#EBEBFF";
    public const string HajipurPageBg = "#F5F5FF";

    // Logos
    public const string SantejLogo = "assets/image/logo_santej.svg";
    public const string HajipurLogo = "assets/image/logo_hajipur.svg";

    // Dynamic resolution helpers
    public static string PrimaryColor => BranchFlag == 2 ? HajipurPrimaryColor : SantejPrimaryColor;
    public static string PrimaryBg => BranchFlag == 2 ? HajipurPrimaryBg : SantejPrimaryBg;
    public static string PageBg => BranchFlag == 2 ? HajipurPageBg : SantejPageBg;
    public static string LogoUrl => BranchFlag == 2 ? HajipurLogo : SantejLogo;
}
