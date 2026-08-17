namespace DeepPolymer.Constants;

public static class ColorConstant
{
    // 1 for Santej, 2 for Hajipur
    public const int BranchFlag = 2;

    // Santej Colors
    public const string SantejPrimaryColor = "#ff0000";
    public const string SantejPrimaryBg = "#FFE5E5";

    // Hajipur Colors
    public const string HajipurPrimaryColor = "#0405AB";
    public const string HajipurPrimaryBg = "#EBEBFF";

    // Logos
    public const string SantejLogo = "assets/image/logo_santej.svg";
    public const string HajipurLogo = "assets/image/logo_hajipur.svg";

    // Dynamic resolution helpers
    public static string PrimaryColor => BranchFlag == 2 ? HajipurPrimaryColor : SantejPrimaryColor;
    public static string PrimaryBg => BranchFlag == 2 ? HajipurPrimaryBg : SantejPrimaryBg;
    public static string LogoUrl => BranchFlag == 2 ? HajipurLogo : SantejLogo;
}
