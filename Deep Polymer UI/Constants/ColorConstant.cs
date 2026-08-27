namespace DeepPolymer.Constants;

public static class ColorConstant
{
    // 1 for Santej, 2 for Hajipur
    public const int BranchFlag = 2;

    // 1 for Admin, 2 for PMR Generator, 3 for Lab User, 4 for Production User (Santej), 5 for Production Head (Hajipur), 6 for Dispatch User (Hajipur), 7 for Marketing User (Hajipur)
    public const int RoleFlag = 8;

    // Helper properties
    public static bool IsAdmin => RoleFlag == 1;
    public static bool IsPmrGenerator => RoleFlag == 2;
    public static bool IsLabUser => RoleFlag == 3;
    public static bool IsProductionUser => RoleFlag == 4;
    public static bool IsProductionHead => RoleFlag == 5;
    public static bool IsDispatchUser => RoleFlag == 6;
    public static bool IsMarketingUser => RoleFlag == 7;
    public static bool IsHajipurProductionUser => RoleFlag == 8;

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
