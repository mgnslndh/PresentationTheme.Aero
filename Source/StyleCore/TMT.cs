namespace StyleCore
{
    public enum TMT
    {
        RESERVEDLOW = 0,
        RESERVEDHIGH = 7999,

        DIBDATA = 2,
        GLYPHDIBDATA = 8,

        _LoadThemeMetrics = 1,
        _BaseClassIdx = 10,
        _PartGrp = 11,
        _UnknownAlwaysMinusOne = 12,
        _DrawObj = 16,
        _TextObj = 17,
        _ImageInfo = 18,
        _ImageInfoRgn = 19,
        _ClsGrpEnd = 20,

        ENUM = 200,
        STRING = 201,
        INT = 202,
        BOOL = 203,
        COLOR = 204,
        MARGINS = 205,
        FILENAME = 206,
        SIZE = 207,
        POSITION = 208,
        RECT = 209,
        FONT = 210,
        INTLIST = 211,
        HBITMAP = 212,
        DISKSTREAM = 213,
        STREAM = 214,
        BITMAPREF = 215,
        FLOAT = 216,
        FLOATLIST = 217,
        SIMPLIFIEDIMAGETYPE = 240,
        HCCOLOR = 241,
        COLORSCHEMES = 401,
        SIZES = 402,
        CHARSET = 403,
        NAME = 600,
        DISPLAYNAME = 601,
        TOOLTIP = 602,
        COMPANY = 603,
        AUTHOR = 604,
        COPYRIGHT = 605,
        URL = 606,
        VERSION = 607,
        DESCRIPTION = 608,
        FIRST_RCSTRING_NAME = DISPLAYNAME,
        LAST_RCSTRING_NAME = DESCRIPTION,
        CAPTIONFONT = 801,
        SMALLCAPTIONFONT = 802,
        MENUFONT = 803,
        STATUSFONT = 804,
        MSGBOXFONT = 805,
        ICONTITLEFONT = 806,
        HEADING1FONT = 807,
        HEADING2FONT = 808,
        BODYFONT = 809,
        FIRSTFONT = CAPTIONFONT,
        LASTFONT = BODYFONT,
        FLATMENUS = 1001,
        FIRSTBOOL = FLATMENUS,
        LASTBOOL = FLATMENUS,
        SIZINGBORDERWIDTH = 1201,
        SCROLLBARWIDTH = 1202,
        SCROLLBARHEIGHT = 1203,
        CAPTIONBARWIDTH = 1204,
        CAPTIONBARHEIGHT = 1205,
        SMCAPTIONBARWIDTH = 1206,
        SMCAPTIONBARHEIGHT = 1207,
        MENUBARWIDTH = 1208,
        MENUBARHEIGHT = 1209,
        PADDEDBORDERWIDTH = 1210,
        FIRSTSIZE = SIZINGBORDERWIDTH,
        LASTSIZE = PADDEDBORDERWIDTH,
        MINCOLORDEPTH = 1301,
        FIRSTINT = MINCOLORDEPTH,
        LASTINT = MINCOLORDEPTH,
        CSSNAME = 1401,
        XMLNAME = 1402,
        LASTUPDATED = 1403,
        ALIAS = 1404,
        FIRSTSTRING = CSSNAME,
        LASTSTRING = ALIAS,
        SCROLLBAR = 1601,
        BACKGROUND = 1602,
        ACTIVECAPTION = 1603,
        INACTIVECAPTION = 1604,
        MENU = 1605,
        WINDOW = 1606,
        WINDOWFRAME = 1607,
        MENUTEXT = 1608,
        WINDOWTEXT = 1609,
        CAPTIONTEXT = 1610,
        ACTIVEBORDER = 1611,
        INACTIVEBORDER = 1612,
        APPWORKSPACE = 1613,
        HIGHLIGHT = 1614,
        HIGHLIGHTTEXT = 1615,
        BTNFACE = 1616,
        BTNSHADOW = 1617,
        GRAYTEXT = 1618,
        BTNTEXT = 1619,
        INACTIVECAPTIONTEXT = 1620,
        BTNHIGHLIGHT = 1621,
        DKSHADOW3D = 1622,
        LIGHT3D = 1623,
        INFOTEXT = 1624,
        INFOBK = 1625,
        BUTTONALTERNATEFACE = 1626,
        HOTTRACKING = 1627,
        GRADIENTACTIVECAPTION = 1628,
        GRADIENTINACTIVECAPTION = 1629,
        MENUHILIGHT = 1630,
        MENUBAR = 1631,
        FIRSTCOLOR = SCROLLBAR,
        LASTCOLOR = MENUBAR,
        FROMHUE1 = 1801,
        FROMHUE2 = 1802,
        FROMHUE3 = 1803,
        FROMHUE4 = 1804,
        FROMHUE5 = 1805,
        TOHUE1 = 1806,
        TOHUE2 = 1807,
        TOHUE3 = 1808,
        TOHUE4 = 1809,
        TOHUE5 = 1810,
        FROMCOLOR1 = 2001,
        FROMCOLOR2 = 2002,
        FROMCOLOR3 = 2003,
        FROMCOLOR4 = 2004,
        FROMCOLOR5 = 2005,
        TOCOLOR1 = 2006,
        TOCOLOR2 = 2007,
        TOCOLOR3 = 2008,
        TOCOLOR4 = 2009,
        TOCOLOR5 = 2010,
        TRANSPARENT = 2201,
        AUTOSIZE = 2202,
        BORDERONLY = 2203,
        COMPOSITED = 2204,
        BGFILL = 2205,
        GLYPHTRANSPARENT = 2206,
        GLYPHONLY = 2207,
        ALWAYSSHOWSIZINGBAR = 2208,
        MIRRORIMAGE = 2209,
        UNIFORMSIZING = 2210,
        INTEGRALSIZING = 2211,
        SOURCEGROW = 2212,
        SOURCESHRINK = 2213,
        DRAWBORDERS = 2214,
        NOETCHEDEFFECT = 2215,
        TEXTAPPLYOVERLAY = 2216,
        TEXTGLOW = 2217,
        TEXTITALIC = 2218,
        COMPOSITEDOPAQUE = 2219,
        LOCALIZEDMIRRORIMAGE = 2220,
        IMAGECOUNT = 2401,
        ALPHALEVEL = 2402,
        BORDERSIZE = 2403,
        ROUNDCORNERWIDTH = 2404,
        ROUNDCORNERHEIGHT = 2405,
        GRADIENTRATIO1 = 2406,
        GRADIENTRATIO2 = 2407,
        GRADIENTRATIO3 = 2408,
        GRADIENTRATIO4 = 2409,
        GRADIENTRATIO5 = 2410,
        PROGRESSCHUNKSIZE = 2411,
        PROGRESSSPACESIZE = 2412,
        SATURATION = 2413,
        TEXTBORDERSIZE = 2414,
        ALPHATHRESHOLD = 2415,
        WIDTH = 2416,
        HEIGHT = 2417,
        GLYPHINDEX = 2418,
        TRUESIZESTRETCHMARK = 2419,
        MINDPI1 = 2420,
        MINDPI2 = 2421,
        MINDPI3 = 2422,
        MINDPI4 = 2423,
        MINDPI5 = 2424,
        TEXTGLOWSIZE = 2425,
        FRAMESPERSECOND = 2426,
        PIXELSPERFRAME = 2427,
        ANIMATIONDELAY = 2428,
        GLOWINTENSITY = 2429,
        OPACITY = 2430,
        COLORIZATIONCOLOR = 2431,
        COLORIZATIONOPACITY = 2432,
        MINDPI6 = 2433,
        MINDPI7 = 2434,
        GLYPHFONT = 2601,
        IMAGEFILE = 3001,
        IMAGEFILE1 = 3002,
        IMAGEFILE2 = 3003,
        IMAGEFILE3 = 3004,
        IMAGEFILE4 = 3005,
        IMAGEFILE5 = 3006,
        GLYPHIMAGEFILE = 3008,
        IMAGEFILE6 = 3009,
        IMAGEFILE7 = 3010,
        TEXT = 3201,
        CLASSICVALUE = 3202,
        OFFSET = 3401,
        TEXTSHADOWOFFSET = 3402,
        MINSIZE = 3403,
        MINSIZE1 = 3404,
        MINSIZE2 = 3405,
        MINSIZE3 = 3406,
        MINSIZE4 = 3407,
        MINSIZE5 = 3408,
        NORMALSIZE = 3409,
        MINSIZE6 = 3410,
        MINSIZE7 = 3411,
        SIZINGMARGINS = 3601,
        CONTENTMARGINS = 3602,
        CAPTIONMARGINS = 3603,
        BORDERCOLOR = 3801,
        FILLCOLOR = 3802,
        TEXTCOLOR = 3803,
        EDGELIGHTCOLOR = 3804,
        EDGEHIGHLIGHTCOLOR = 3805,
        EDGESHADOWCOLOR = 3806,
        EDGEDKSHADOWCOLOR = 3807,
        EDGEFILLCOLOR = 3808,
        TRANSPARENTCOLOR = 3809,
        GRADIENTCOLOR1 = 3810,
        GRADIENTCOLOR2 = 3811,
        GRADIENTCOLOR3 = 3812,
        GRADIENTCOLOR4 = 3813,
        GRADIENTCOLOR5 = 3814,
        SHADOWCOLOR = 3815,
        GLOWCOLOR = 3816,
        TEXTBORDERCOLOR = 3817,
        TEXTSHADOWCOLOR = 3818,
        GLYPHTEXTCOLOR = 3819,
        GLYPHTRANSPARENTCOLOR = 3820,
        FILLCOLORHINT = 3821,
        BORDERCOLORHINT = 3822,
        ACCENTCOLORHINT = 3823,
        TEXTCOLORHINT = 3824,
        HEADING1TEXTCOLOR = 3825,
        HEADING2TEXTCOLOR = 3826,
        BODYTEXTCOLOR = 3827,
        BGTYPE = 4001,
        BORDERTYPE = 4002,
        FILLTYPE = 4003,
        SIZINGTYPE = 4004,
        HALIGN = 4005,
        CONTENTALIGNMENT = 4006,
        VALIGN = 4007,
        OFFSETTYPE = 4008,
        ICONEFFECT = 4009,
        TEXTSHADOWTYPE = 4010,
        IMAGELAYOUT = 4011,
        GLYPHTYPE = 4012,
        IMAGESELECTTYPE = 4013,
        GLYPHFONTSIZINGTYPE = 4014,
        TRUESIZESCALINGTYPE = 4015,
        USERPICTURE = 5001,
        DEFAULTPANESIZE = 5002,
        BLENDCOLOR = 5003,
        CUSTOMSPLITRECT = 5004,
        ANIMATIONBUTTONRECT = 5005,
        ANIMATIONDURATION = 5006,
        TRANSITIONDURATIONS = 6000,
        SCALEDBACKGROUND = 7001,
        ATLASIMAGE = 8000,
        ATLASINPUTIMAGE = 8001,
        ATLASRECT = 8002,

        THEMEMETRICS = 1,
        DIBDATA1 = 3,
        DIBDATA2 = 4,
        DIBDATA3 = 5,
        DIBDATA4 = 6,
        DIBDATA5 = 7,
        NTLDATA = 9,
        PARTJUMPTABLE = 10,
        STATEJUMPTABLE = 11,
        JUMPTOPARENT = 12,
        ENUMDEF = 13,
        ENUMVAL = 14,
        RESERVED1 = 15,
        DRAWOBJ = 16,
        TEXTOBJ = 17,
        RGNLIST = 18,
        RGNDATA = 19,
        ENDOFCLASS = 20,
        UNKNOWN = 21,
        DIBDATA6 = 22,
        DIBDATA7 = 23,

        SIMPLIFIEDIMAGE = 5100,
        HCSIMPLIFIEDIMAGE = 5101,
        HCGLYPHBGCOLOR = 5102,
        UNKNOWN_5106 = 5106,
        TRANSPARENTMARGINS = 5107,
        HCBORDERCOLOR = 5110,
        HCFILLCOLOR = 5111,
        HCTEXTCOLOR = 5112,
        HCEDGEHIGHLIGHTCOLOR = 5113,
        HCEDGESHADOWCOLOR = 5114,
        HCTEXTBORDERCOLOR = 5115,
        HCTEXTSHADOWCOLOR = 5116,
        HCGLOWCOLOR = 5117,
        HCHEADING1TEXTCOLOR = 5118,
        HCHEADING2TEXTCOLOR = 5119,
        HCBODYTEXTCOLOR = 5120,
        HCGLYPHCOLOR = 5121,
        HCHOTTRACKING = 5122,
        PPIPLATEAU1 = 5128,
        PPIPLATEAU2 = 5129,
        PPIPLATEAU3 = 5130,
        IMAGEPLATEAU1 = 5131,
        IMAGEPLATEAU2 = 5132,
        IMAGEPLATEAU3 = 5133,
        GLYPHIMAGEPLATEAU1 = 5134,
        GLYPHIMAGEPLATEAU2 = 5135,
        GLYPHIMAGEPLATEAU3 = 5136,
        CONTENTMARGINSPLATEAU1 = 5137,
        CONTENTMARGINSPLATEAU2 = 5138,
        CONTENTMARGINSPLATEAU3 = 5139,
        SIZINGMARGINSPLATEAU1 = 5140,
        SIZINGMARGINSPLATEAU2 = 5141,
        SIZINGMARGINSPLATEAU3 = 5142,
        COMPOSEDIMAGEFILE = 5143,
        COMPOSEDIMAGEFILE1 = 5144,
        COMPOSEDIMAGEFILE2 = 5145,
        COMPOSEDIMAGEFILE3 = 5146,
        COMPOSEDIMAGEFILE4 = 5147,
        COMPOSEDIMAGEFILE5 = 5148,
        COMPOSEDGLYPHIMAGEFILE = 5149,
        COMPOSEDIMAGEFILE6 = 5152,
        COMPOSEDIMAGEFILE7 = 5153,
        ANIMATION = 20000,
        TIMINGFUNCTION = 20100,
    }
}
