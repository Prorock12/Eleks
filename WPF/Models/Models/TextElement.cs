﻿using System.Windows.Media;
using Models.Interfaces.Models;

namespace Models.Models
{
    public class TextElement : VisualElement, ITextElement
    {
        #region constants

        private const string DefaultText = @"{\rtf1\ansi\deff3\adeflang1025
{\fonttbl{\f0\froman\fprq2\fcharset0 Times New Roman;}{\f1\froman\fprq2\fcharset2 Symbol;}{\f2\fswiss\fprq2\fcharset0 Arial;}{\f3\froman\fprq2\fcharset0 Liberation Serif{\*\falt Times New Roman};}{\f4\froman\fprq2\fcharset0 Liberation Sans{\*\falt Arial};}{\f5\froman\fprq2\fcharset0 Symbol;}{\f6\froman\fprq2\fcharset0 OpenSymbol{\*\falt Arial Unicode MS};}{\f7\froman\fprq2\fcharset0 DejaVu Sans;}{\f8\froman\fprq2\fcharset0 Open Sans{\*\falt Arial};}{\f9\fnil\fprq2\fcharset0 Droid Sans Fallback;}{\f10\fnil\fprq2\fcharset0 OpenSymbol{\*\falt Arial Unicode MS};}{\f11\fnil\fprq2\fcharset0 DejaVu Sans;}{\f12\fnil\fprq2\fcharset0 Open Sans{\*\falt Arial};}{\f13\fnil\fprq2\fcharset0 FreeSans;}{\f14\fnil\fprq2\fcharset0 Symbol;}}
{\colortbl;\red0\green0\blue0;\red0\green0\blue255;\red0\green255\blue255;\red0\green255\blue0;\red255\green0\blue255;\red255\green0\blue0;\red255\green255\blue0;\red255\green255\blue255;\red0\green0\blue128;\red0\green128\blue128;\red0\green128\blue0;\red128\green0\blue128;\red128\green0\blue0;\red128\green128\blue0;\red128\green128\blue128;\red192\green192\blue192;\red0\green0\blue10;\red0\green0\blue1;}
{\stylesheet{\s0\snext0\ql\nowidctlpar\hyphpar0\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\kerning0\loch\f3\fs24\lang1033 Normal;}
{\s1\sbasedon50\snext1\ql\nowidctlpar\hyphpar0\sb240\sa120\keepn\ltrpar\cf17\b\dbch\af9\langfe2052\dbch\af13\afs36\alang1081\ab\loch\f4\fs36\lang1033 Heading 1;}
{\s2\sbasedon50\snext2\ql\nowidctlpar\hyphpar0\sb200\sa120\keepn\ltrpar\cf17\b\dbch\af9\langfe2052\dbch\af13\afs32\alang1081\ab\loch\f4\fs32\lang1033 Heading 2;}
{\s3\sbasedon50\snext3\ql\nowidctlpar\hyphpar0\sb140\sa120\keepn\ltrpar\cf15\b\dbch\af9\langfe2052\dbch\af13\afs28\alang1081\ab\loch\f4\fs28\lang1033 Heading 3;}
{\*\cs15\snext15 WW8Num1z0;}
{\*\cs16\snext16 WW8Num1z1;}
{\*\cs17\snext17 WW8Num1z2;}
{\*\cs18\snext18 WW8Num1z3;}
{\*\cs19\snext19 WW8Num1z4;}
{\*\cs20\snext20 WW8Num1z5;}
{\*\cs21\snext21 WW8Num1z6;}
{\*\cs22\snext22 WW8Num1z7;}
{\*\cs23\snext23 WW8Num1z8;}
{\*\cs24\snext24 WW8Num2z0;}
{\*\cs25\snext25 WW8Num2z1;}
{\*\cs26\snext26 WW8Num2z2;}
{\*\cs27\snext27 WW8Num2z3;}
{\*\cs28\snext28 WW8Num2z4;}
{\*\cs29\snext29 WW8Num2z5;}
{\*\cs30\snext30 WW8Num2z6;}
{\*\cs31\snext31 WW8Num2z7;}
{\*\cs32\snext32 WW8Num2z8;}
{\*\cs33\snext33\dbch\af10\loch\f5 WW8Num3z0;}
{\*\cs34\snext34\dbch\af10\loch\f6 WW8Num3z1;}
{\*\cs35\snext35\dbch\af10\dbch\af10\loch\f6 Bullets;}
{\*\cs36\snext36\cf9\ul\ulc0\langfe255\alang255\lang255 Internet Link;}
{\*\cs37\snext37\cf13\ul\ulc0\langfe255\alang255\lang255 Visited Internet Link;}
{\*\cs38\snext38\dbch\af14 ListLabel 1;}
{\*\cs39\snext39\dbch\af10 ListLabel 2;}
{\*\cs40\snext40\b0\dbch\af14\loch\f7\fs21 ListLabel 3;}
{\*\cs41\snext41\dbch\af10 ListLabel 4;}
{\*\cs42\snext42\dbch\af10 ListLabel 5;}
{\*\cs43\snext43\dbch\af14 ListLabel 6;}
{\*\cs44\snext44\dbch\af10 ListLabel 7;}
{\*\cs45\snext45\dbch\af10 ListLabel 8;}
{\*\cs46\snext46\dbch\af14 ListLabel 9;}
{\*\cs47\snext47\dbch\af10 ListLabel 10;}
{\*\cs48\snext48\dbch\af10 ListLabel 11;}
{\*\cs49\snext49\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\loch\f7\fs21 ListLabel 12;}
{\s50\sbasedon0\snext51\ql\nowidctlpar\hyphpar0\sb240\sa120\keepn\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs28\alang1081\loch\f4\fs28\lang1033 Heading;}
{\s51\sbasedon0\snext51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033 Text Body;}
{\s52\sbasedon51\snext52\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033 List;}
{\s53\sbasedon0\snext53\ql\nowidctlpar\hyphpar0\sb120\sa120\noline\ltrpar\cf17\i\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\ai\loch\f3\fs24\lang1033 Caption;}
{\s54\sbasedon0\snext54\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033 Index;}
{\s55\sbasedon0\snext55\ql\nowidctlpar\hyphpar0\li567\ri567\lin567\rin567\fi0\sb0\sa283\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033 Quotations;}
{\s56\sbasedon50\snext56\qc\nowidctlpar\hyphpar0\sb240\sa120\keepn\ltrpar\cf17\b\dbch\af9\langfe2052\dbch\af13\afs56\alang1081\ab\loch\f4\fs56\lang1033 Title;}
{\s57\sbasedon50\snext57\qc\nowidctlpar\hyphpar0\sb60\sa120\keepn\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs36\alang1081\loch\f4\fs36\lang1033 Subtitle;}
{\s58\sbasedon0\snext58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033 Table Contents;}
{\s59\sbasedon58\snext59\qc\nowidctlpar\hyphpar0\noline\ltrpar\cf17\b\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\ab\loch\f3\fs24\lang1033 Table Heading;}
}{\*\listtable{\list\listtemplateid1
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi-432\li792}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi-576\li936}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi-720\li1080}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi-864\li1224}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi-1008\li1368}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi-1152\li1512}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi-1296\li1656}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi-1440\li1800}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi-1584\li1944}\listid1}
{\list\listtemplateid2
{\listlevel\levelnfc23\leveljc0\levelstartat1\levelfollow0{\leveltext \'01\u61623 ?;}{\levelnumbers;}\f15\b0\dbch\af14\fi-360\li720}
{\listlevel\levelnfc23\leveljc0\levelstartat1\levelfollow0{\leveltext \'01\u9702 ?;}{\levelnumbers;}\f16\dbch\af10\fi-360\li1080}
{\listlevel\levelnfc23\leveljc0\levelstartat1\levelfollow0{\leveltext \'01\u9642 ?;}{\levelnumbers;}\f16\dbch\af10\fi-360\li1440}
{\listlevel\levelnfc23\leveljc0\levelstartat1\levelfollow0{\leveltext \'01\u61623 ?;}{\levelnumbers;}\f15\dbch\af14\fi-360\li1800}
{\listlevel\levelnfc23\leveljc0\levelstartat1\levelfollow0{\leveltext \'01\u9702 ?;}{\levelnumbers;}\f16\dbch\af10\fi-360\li2160}
{\listlevel\levelnfc23\leveljc0\levelstartat1\levelfollow0{\leveltext \'01\u9642 ?;}{\levelnumbers;}\f16\dbch\af10\fi-360\li2520}
{\listlevel\levelnfc23\leveljc0\levelstartat1\levelfollow0{\leveltext \'01\u61623 ?;}{\levelnumbers;}\f15\dbch\af14\fi-360\li2880}
{\listlevel\levelnfc23\leveljc0\levelstartat1\levelfollow0{\leveltext \'01\u9702 ?;}{\levelnumbers;}\f16\dbch\af10\fi-360\li3240}
{\listlevel\levelnfc23\leveljc0\levelstartat1\levelfollow0{\leveltext \'01\u9642 ?;}{\levelnumbers;}\f16\dbch\af10\fi-360\li3600}\listid2}
{\list\listtemplateid3
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi0\li0}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi0\li0}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi0\li0}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi0\li0}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi0\li0}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi0\li0}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi0\li0}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi0\li0}
{\listlevel\levelnfc255\leveljc0\levelstartat1\levelfollow2{\leveltext \'00;}{\levelnumbers;}\fi0\li0}\listid3}
}{\listoverridetable{\listoverride\listid1\listoverridecount0\ls1}{\listoverride\listid2\listoverridecount0\ls2}{\listoverride\listid3\listoverridecount0\ls3}}{\*\generator LibreOffice/6.0.7.3$Linux_X86_64 LibreOffice_project/00m0$Build-3}{\info{\creatim\yr2017\mo8\dy2\hr11\min9}{\revtim\yr2019\mo9\dy21\hr14\min2}{\printim\yr0\mo0\dy0\hr0\min0}}{\*\userprops}\deftab709
\hyphauto0\viewscale100
{\*\pgdsctbl
{\pgdsc0\pgdscuse451\pgwsxn11906\pghsxn16838\marglsxn1134\margrsxn1134\margtsxn1134\margbsxn1134\pgdscnxt0 Default Style;}}
\formshade{\*\pgdscno0}\paperh16838\paperw11906\margl1134\margr1134\margt1134\margb1134\sectd\sbknone\sectunlocked1\pgndec\pgwsxn11906\pghsxn16838\marglsxn1134\margrsxn1134\margtsxn1134\margbsxn1134\ftnbj\ftnstart1\ftnrstcont\ftnnar\aenddoc\aftnrstcont\aftnstart1\aftnnrlc\htmautsp
{\*\ftnsep\chftnsep}\viewbksp1{\*\background{\shp{\*\shpinst{\sp{\sn shapeType}{\sv 1}}{\sp{\sn fillColor}{\sv 16777215}}}}}\pgndec\pard\plain \s56\qc\nowidctlpar\hyphpar0\sb240\sa120\keepn\ltrpar\cf17\b\dbch\af9\langfe2052\dbch\af13\afs56\alang1081\ab\loch\f4\fs56\lang1033\qc\sb240\sa120{\cbpat8\cbpat8\fs21\rtlch \ltrch\loch
Lorem ipsum }
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7

\par \pard\plain \s1\ql\nowidctlpar\hyphpar0\sb240\sa120\keepn\ltrpar\cf17\b\dbch\af9\langfe2052\dbch\af13\afs36\alang1081\ab\loch\f4\fs36\lang1033{\listtext\pard\plain }\ilvl0\ls1 \li792\ri0\lin792\rin0\fi-432\li0\ri0\lin0\rin0\fi-432\sb240\sa120\keepn{\rtlch \ltrch\loch
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc ac faucibus odio. }
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Vestibulum neque massa, scelerisque sit amet ligula eu, congue molestie mi. Praesent ut varius sem. Nullam at porttitor arcu, nec lacinia nisi. Ut ac dolor vitae odio interdum condimentum. }{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b\dbch\af11\ab\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Vivamus dapibus sodales ex, vitae malesuada ipsum cursus convallis. Maecenas sed egestas nulla, ac condimentum orci. }{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Mauris diam felis, vulputate ac suscipit et, iaculis non est. Curabitur semper arcu ac ligula semper, nec luctus nisl blandit. Integer lacinia ante ac libero lobortis imperdiet. }{\scaps0\caps0\cf1\expnd0\expndtw0\i\b0\dbch\af11\ai\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Nullam mollis convallis ipsum, ac accumsan nunc vehicula vitae. }{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Nulla eget justo in felis tristique fringilla. Morbi sit amet tortor quis risus auctor condimentum. Morbi in ullamcorper elit. Nulla iaculis tellus sit amet mauris tempus fringilla.}
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Maecenas mauris lectus, lobortis et purus mattis, blandit dictum tellus.}
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033{\listtext\pard\plain \b0\dbch\af14\loch\f7\fs21 \u61623\'3f\tab}\ilvl0\ls2 \li720\ri0\lin720\rin0\fi-360\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b\dbch\af11\ab\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Maecenas non lorem quis tellus placerat varius. }
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033{\listtext\pard\plain \b0\dbch\af14\loch\f7\fs21 \u61623\'3f\tab}\ilvl0\ls2 \li720\ri0\lin720\rin0\fi-360\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i\b0\dbch\af11\ai\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Nulla facilisi. }
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033{\listtext\pard\plain \b0\dbch\af14\loch\f7\fs21 \u61623\'3f\tab}\ilvl0\ls2 \li720\ri0\lin720\rin0\fi-360\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\ul\ulc0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Aenean congue fringilla justo ut aliquam. }
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033{\listtext\pard\plain \b0\dbch\af14\loch\f7\fs21 \u61623\'3f\tab}\ilvl0\ls2 \li720\ri0\lin720\rin0\fi-360\qj\widctlpar\sb0\sa225{{\field{\*\fldinst HYPERLINK }{\fldrslt {\cs36\cf9\ul\ulc0\langfe255\alang255\lang255\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Mauris id ex erat. }{}}}\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Nunc vulputate neque vitae justo facilisis, non condimentum ante sagittis. }
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033
{\listtext\pard\plain \b0\dbch\af14\loch\f7\fs21 \u61623\'3f\tab}\ilvl0\ls2 \li720\ri0\lin720\rin0\fi-360\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Morbi viverra semper lorem nec molestie. }
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033
{\listtext\pard\plain \b0\dbch\af14\loch\f7\fs21 \u61623\'3f\tab}\ilvl0\ls2 \li720\ri0\lin720\rin0\fi-360\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Maecenas tincidunt est efficitur ligula euismod, sit amet ornare est vulputate.}
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
In non mauris justo. Duis vehicula mi vel mi pretium, a viverra erat efficitur. Cras aliquam est ac eros varius, id iaculis dui auctor. Duis pretium neque ligula, et pulvinar mi placerat et. Nulla nec nunc sit amet nunc posuere vestibulum. Ut id neque eget tortor mattis tristique. Donec ante est, blandit sit amet tristique vel, lacinia pulvinar arcu. Pellentesque scelerisque fermentum erat, id posuere justo pulvinar ut. Cras id eros sed enim aliquam lobortis. Sed lobortis nisl ut eros efficitur tincidunt. Cras justo mi, porttitor quis mattis vel, ultricies ut purus. Ut facilisis et lacus eu cursus.}
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
In eleifend velit vitae libero sollicitudin euismod. Fusce vitae vestibulum velit. Pellentesque vulputate lectus quis pellentesque commodo. Aliquam erat volutpat. Vestibulum in egestas velit. Pellentesque fermentum nisl vitae fringilla venenatis. Etiam id mauris vitae orci maximus ultricies. }
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7

\par \pard\plain \s1\ql\nowidctlpar\hyphpar0\sb240\sa120\keepn\ltrpar\cf17\b\dbch\af9\langfe2052\dbch\af13\afs36\alang1081\ab\loch\f4\fs36\lang1033{\listtext\pard\plain }\ilvl0\ls1 \li792\ri0\lin792\rin0\fi-432\li0\ri0\lin0\rin0\fi-432\sb240\sa120\keepn{\rtlch \ltrch\loch
Cras fringilla ipsum magna, in fringilla dui commodo a.}
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7

\par \trowd\trql\trleft53\ltrrow\trrh450\trpaddft3\trpaddt0\trpaddfl3\trpaddl0\trpaddfb3\trpaddb0\trpaddfr3\trpaddr0\clbrdrt\brdrs\brdrw5\brdrcf18\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx770\clbrdrt\brdrs\brdrw5\brdrcf18\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx6434\clbrdrt\brdrs\brdrw5\brdrcf18\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx7992\clbrdrt\brdrs\brdrw5\brdrcf18\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clbrdrr\brdrs\brdrw5\brdrcf18\clpadfr3\clpadr55\clcbpat8\cellx9690\pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql\widctlpar\sb0\sa225\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
\cell\pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Lorem ipsum}\cell\pard\plain \s58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql{\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Lorem ipsum}\cell\pard\plain \s58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql{\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Lorem ipsum}\cell\row\pard\trowd\trql\trleft53\ltrrow\trpaddft3\trpaddt0\trpaddfl3\trpaddl0\trpaddfb3\trpaddb0\trpaddfr3\trpaddr0\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx770\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx6434\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx7992\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clbrdrr\brdrs\brdrw5\brdrcf18\clpadfr3\clpadr55\clcbpat8\cellx9690\pard\plain \s58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql{\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
1}\cell\pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
In eleifend velit vitae libero sollicitudin euismod.}\cell\pard\plain \s58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql{\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Lorem}\cell\pard\plain \s58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
\cell\row\pard\trowd\trql\trleft53\ltrrow\trpaddft3\trpaddt0\trpaddfl3\trpaddl0\trpaddfb3\trpaddb0\trpaddfr3\trpaddr0\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx770\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx6434\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx7992\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clbrdrr\brdrs\brdrw5\brdrcf18\clpadfr3\clpadr55\clcbpat8\cellx9690\pard\plain \s58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql{\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
2}\cell\pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Cras fringilla ipsum magna, in fringilla dui commodo a.}\cell\pard\plain \s58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql{\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Ipsum}\cell\pard\plain \s58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
\cell\row\pard\trowd\trql\trleft53\ltrrow\trpaddft3\trpaddt0\trpaddfl3\trpaddl0\trpaddfb3\trpaddb0\trpaddfr3\trpaddr0\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx770\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx6434\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx7992\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clbrdrr\brdrs\brdrw5\brdrcf18\clpadfr3\clpadr55\clcbpat8\cellx9690\pard\plain \s58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql{\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
3}\cell\pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\ab\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Fusce vitae vestibulum velit. }\cell\pard\plain \s58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql{\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Lorem}\cell\pard\plain \s58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
\cell\row\pard\trowd\trql\trleft53\ltrrow\trpaddft3\trpaddt0\trpaddfl3\trpaddl0\trpaddfb3\trpaddb0\trpaddfr3\trpaddr0\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx770\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx6434\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clpadfr3\clpadr55\clcbpat8\cellx7992\clpadfl3\clpadl55\clbrdrl\brdrs\brdrw5\brdrcf18\clpadft3\clpadt51\clbrdrb\brdrs\brdrw5\brdrcf18\clpadfb3\clpadb55\clbrdrr\brdrs\brdrw5\brdrcf18\clpadfr3\clpadr55\clcbpat8\cellx9690\pard\plain \s58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql{\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
4}\cell\pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Etiam vehicula luctus fermentum.}\cell\pard\plain \s58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql{\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Ipsum}\cell\pard\plain \s58\ql\nowidctlpar\hyphpar0\noline\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\intbl\ql\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
\cell\row\pard\pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af11\rtlch \ltrch\loch\fs21\loch\f7\hich\af7
Etiam vehicula luctus fermentum. In vel metus congue, pulvinar lectus vel, fermentum dui. Maecenas ante orci, egestas ut aliquet sit amet, sagittis a magna. Aliquam ante quam, pellentesque ut dignissim quis, laoreet eget est. Aliquam erat volutpat. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Ut ullamcorper justo sapien, in cursus libero viverra eget. Vivamus auctor imperdiet urna, at pulvinar leo posuere laoreet. Suspendisse neque nisl, fringilla at iaculis scelerisque, ornare vel dolor. Ut et pulvinar nunc. Pellentesque fringilla mollis efficitur. Nullam venenatis commodo imperdiet. Morbi velit neque, semper quis lorem quis, efficitur dignissim ipsum. Ut ac lorem sed turpis imperdiet eleifend sit amet id sapien.}
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af12\rtlch \ltrch\loch\fs21\loch\f8\hich\af8
Maecenas non lorem quis tellus placerat varius. Nulla facilisi. Aenean congue fringilla justo ut aliquam. Mauris id ex erat. Nunc vulputate neque vitae justo facilisis, non condimentum ante sagittis. Morbi viverra semper lorem nec molestie. Maecenas tincidunt est efficitur ligula euismod, sit amet ornare est vulputate.}
\par \shpwr2\shpwrk3\shpbypara\shpbyignore\shptop0\shpbxcolumn\shpbxignore\shpleft2819\pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch
{\*\flymaincnt5\flyanchor0\flycntnt}{\shp{\*\shpinst\shpwr2\shpwrk3\shpbypara\shpbyignore\shptop0\shpbottom2660\shpbxcolumn\shpbxignore\shpleft2819\shpright6819{\sp{\sn shapeType}{\sv 75}}{\sp{\sn wzDescription}{\sv }}{\sp{\sn wzName}{\sv }}{\sp{\sn pib}{\sv {\pict\picscalex100\picscaley100\piccropl0\piccropr0\piccropt0\piccropb0\picw200\pich133\picwgoal4000\pichgoal2660\jpegblip
ffd8ffe000104a46494600010101004800480000ffe20c584943435f50524f46494c4500010100000c484c696e6f021000006d6e74725247422058595a2007ce
00020009000600310000616373704d5346540000000049454320735247420000000000000000000000000000f6d6000100000000d32d48502020000000000000
00000000000000000000000000000000000000000000000000000000000000000000000000000000001163707274000001500000003364657363000001840000
006c77747074000001f000000014626b707400000204000000147258595a00000218000000146758595a0000022c000000146258595a0000024000000014646d
6e640000025400000070646d6464000002c400000088767565640000034c0000008676696577000003d4000000246c756d69000003f8000000146d6561730000
040c0000002474656368000004300000000c725452430000043c0000080c675452430000043c0000080c625452430000043c0000080c7465787400000000436f
70797269676874202863292031393938204865776c6574742d5061636b61726420436f6d70616e79000064657363000000000000001273524742204945433631
3936362d322e31000000000000000000000012735247422049454336313936362d322e3100000000000000000000000000000000000000000000000000000000
0000000000000000000000000000000000000000000058595a20000000000000f35100010000000116cc58595a20000000000000000000000000000000005859
5a200000000000006fa2000038f50000039058595a2000000000000062990000b785000018da58595a2000000000000024a000000f840000b6cf646573630000
00000000001649454320687474703a2f2f7777772e6965632e636800000000000000000000001649454320687474703a2f2f7777772e6965632e636800000000
00000000000000000000000000000000000000000000000000000000000000000000000000000000000064657363000000000000002e4945432036313936362d
322e312044656661756c742052474220636f6c6f7572207370616365202d207352474200000000000000000000002e4945432036313936362d322e3120446566
61756c742052474220636f6c6f7572207370616365202d20735247420000000000000000000000000000000000000000000064657363000000000000002c5265
666572656e63652056696577696e6720436f6e646974696f6e20696e2049454336313936362d322e3100000000000000000000002c5265666572656e63652056
696577696e6720436f6e646974696f6e20696e2049454336313936362d322e310000000000000000000000000000000000000000000000000000766965770000
00000013a4fe00145f2e0010cf140003edcc0004130b00035c9e0000000158595a2000000000004c09560050000000571fe76d65617300000000000000010000
00000000000000000000000000000000028f0000000273696720000000004352542063757276000000000000040000000005000a000f00140019001e00230028
002d00320037003b00400045004a004f00540059005e00630068006d00720077007c00810086008b00900095009a009f00a400a900ae00b200b700bc00c100c6
00cb00d000d500db00e000e500eb00f000f600fb01010107010d01130119011f0125012b01320138013e0145014c0152015901600167016e0175017c0183018b
0192019a01a101a901b101b901c101c901d101d901e101e901f201fa0203020c0214021d0226022f02380241024b0254025d02670271027a0284028e029802a2
02ac02b602c102cb02d502e002eb02f50300030b03160321032d03380343034f035a03660372037e038a039603a203ae03ba03c703d303e003ec03f904060413
0420042d043b0448045504630471047e048c049a04a804b604c404d304e104f004fe050d051c052b053a05490558056705770586059605a605b505c505d505e5
05f6060606160627063706480659066a067b068c069d06af06c006d106e306f507070719072b073d074f076107740786079907ac07bf07d207e507f8080b081f
08320846085a086e0882089608aa08be08d208e708fb09100925093a094f09640979098f09a409ba09cf09e509fb0a110a270a3d0a540a6a0a810a980aae0ac5
0adc0af30b0b0b220b390b510b690b800b980bb00bc80be10bf90c120c2a0c430c5c0c750c8e0ca70cc00cd90cf30d0d0d260d400d5a0d740d8e0da90dc30dde
0df80e130e2e0e490e640e7f0e9b0eb60ed20eee0f090f250f410f5e0f7a0f960fb30fcf0fec1009102610431061107e109b10b910d710f511131131114f116d
118c11aa11c911e81207122612451264128412a312c312e31303132313431363138313a413c513e5140614271449146a148b14ad14ce14f01512153415561578
159b15bd15e0160316261649166c168f16b216d616fa171d17411765178917ae17d217f7181b18401865188a18af18d518fa19201945196b199119b719dd1a04
1a2a1a511a771a9e1ac51aec1b141b3b1b631b8a1bb21bda1c021c2a1c521c7b1ca31ccc1cf51d1e1d471d701d991dc31dec1e161e401e6a1e941ebe1ee91f13
1f3e1f691f941fbf1fea20152041206c209820c420f0211c2148217521a121ce21fb22272255228222af22dd230a23382366239423c223f0241f244d247c24ab
24da250925382568259725c725f726272657268726b726e827182749277a27ab27dc280d283f287128a228d429062938296b299d29d02a022a352a682a9b2acf
2b022b362b692b9d2bd12c052c392c6e2ca22cd72d0c2d412d762dab2de12e162e4c2e822eb72eee2f242f5a2f912fc72ffe3035306c30a430db3112314a3182
31ba31f2322a3263329b32d4330d3346337f33b833f1342b3465349e34d83513354d358735c235fd3637367236ae36e937243760379c37d738143850388c38c8
39053942397f39bc39f93a363a743ab23aef3b2d3b6b3baa3be83c273c653ca43ce33d223d613da13de03e203e603ea03ee03f213f613fa23fe24023406440a6
40e74129416a41ac41ee4230427242b542f7433a437d43c044034447448a44ce45124555459a45de4622466746ab46f04735477b47c04805484b489148d7491d
496349a949f04a374a7d4ac44b0c4b534b9a4be24c2a4c724cba4d024d4a4d934ddc4e254e6e4eb74f004f494f934fdd5027507150bb51065150519b51e65231
527c52c75313535f53aa53f65442548f54db5528557555c2560f565c56a956f75744579257e0582f587d58cb591a596959b85a075a565aa65af55b455b955be5
5c355c865cd65d275d785dc95e1a5e6c5ebd5f0f5f615fb36005605760aa60fc614f61a261f56249629c62f06343639763eb6440649464e9653d659265e7663d
669266e8673d679367e9683f689668ec6943699a69f16a486a9f6af76b4f6ba76bff6c576caf6d086d606db96e126e6b6ec46f1e6f786fd1702b708670e0713a
719571f0724b72a67301735d73b87414747074cc7528758575e1763e769b76f8775677b37811786e78cc792a798979e77a467aa57b047b637bc27c217c817ce1
7d417da17e017e627ec27f237f847fe5804780a8810a816b81cd8230829282f4835783ba841d848084e3854785ab860e867286d7873b879f8804886988ce8933
899989fe8a648aca8b308b968bfc8c638cca8d318d988dff8e668ece8f368f9e9006906e90d6913f91a89211927a92e3934d93b69420948a94f4955f95c99634
969f970a977597e0984c98b89924999099fc9a689ad59b429baf9c1c9c899cf79d649dd29e409eae9f1d9f8b9ffaa069a0d8a147a1b6a226a296a306a376a3e6
a456a4c7a538a5a9a61aa68ba6fda76ea7e0a852a8c4a937a9a9aa1caa8fab02ab75abe9ac5cacd0ad44adb8ae2daea1af16af8bb000b075b0eab160b1d6b24b
b2c2b338b3aeb425b49cb513b58ab601b679b6f0b768b7e0b859b8d1b94ab9c2ba3bbab5bb2ebba7bc21bc9bbd15bd8fbe0abe84beffbf7abff5c070c0ecc167
c1e3c25fc2dbc358c3d4c451c4cec54bc5c8c646c6c3c741c7bfc83dc8bcc93ac9b9ca38cab7cb36cbb6cc35ccb5cd35cdb5ce36ceb6cf37cfb8d039d0bad13c
d1bed23fd2c1d344d3c6d449d4cbd54ed5d1d655d6d8d75cd7e0d864d8e8d96cd9f1da76dafbdb80dc05dc8add10dd96de1cdea2df29dfafe036e0bde144e1cc
e253e2dbe363e3ebe473e4fce584e60de696e71fe7a9e832e8bce946e9d0ea5beae5eb70ebfbec86ed11ed9cee28eeb4ef40efccf058f0e5f172f1fff28cf319
f3a7f434f4c2f550f5def66df6fbf78af819f8a8f938f9c7fa57fae7fb77fc07fc98fd29fdbafe4bfedcff6dffffffdb00430005040404040305040404060505
06080d0808070708100b0c090d131014131210121214171d1914161c1612121a231a1c1e1f212121141924272420261d202120ffdb0043010506060807080f08
080f201512152020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020ffc2001108008500
c803011100021101031101ffc4001c0000010501010100000000000000000000020001030405060708ffc4001a01000301010101000000000000000000000102
0300040506ffda000c03010002100310000001cef90fb09a72952d6a75cbea4d4e63c8fb5e46b47b7ac13eefbbc600d1ab0076056ce0100416acafcf72f764c5
b2c88cb7775e3dda7264f5754ed3360db03601aa1102d6c81bcfca398411c56ce32d9d4101c847bb834e8bbcea88916beadd3e3db6907534b4989384bd3c6b57
b1dcfd09846af1ab3660044e582d96ce0b8c977982f6f3d37b5257036b9fabd4fd0f0a4558fa5e5acf3a5d3e2d4eecbbc3604bdbb9a4db0e6118183157c160f8
ac5d5a347f15a74410725d6263afe6eaf48eef09d7074996aa0a7cea3eb705d52c4e9e4f68e0af54a83b33289472ae558e432c5c3514af8776343ced624d7f9f
a3d1a27b2b798614fb94983918fcddbe1fd74c0e9e4d74deede75e4647644513222110b640a0d842bc5deb940e0149f97b7dab8d374f1985b3e945d821a0957c
a376f95fa3c359e5ed1e7f5773006e8e5132b156216c81607917b60d2a294e7185b8dbd53cdbc926255e8bdaf1d6c2a6347c89f57cf3ea72e3db9b690fbf799d
368cdd95ca265121608e056f34e8b516a62837675ea796fa5e67a4b9fa6ca6f41fa7f91e7bccf5f3d9f03ba16d27c2d5312d0b197b291d645264e9d652ba065a
6af66b2a894f30e8e9c12dae94b894e8b92d67cef4adcab6267b3f67e7208d2bad7396f84dabbcb61277424f49d5a2d869a74074899200d18311192691ea47a9
5453a1e6b75ca97edcd61e3ccf93ee36c8e00d09d1b4e85a117571eaa248c8656ab2e55467d044da33a326916bd36d293cf3aef21e9001471538fc3e857d5061
015379d829436c2eff003e769c84390442da26d20d608ead92cbeb20a9b20c4ac919908ccf21e7fbce529d6557a79bb6bf0d20451dcace54ca995321c81d9308
b1a28d9aadaef3d1759f31024aee19d779d799ee994ad49e7d274a9372b6996f64be8b7535802719f013a225866d9d73111632309e82d93054684df84e1f55ca
46c80c88a8b2d8cb315972332915b886da9914b6cfb2c61c63c50cc0be311780b366c74acd95ca8b21e05945d642b3653c0b006d19138d710ce8c810c6224766
0483163097af9b9971a73d2e08a8b2cb84a01b239078160632d85b44c076b2bae4d9958098f173833572f51cff00ffc400271000020202020005050101000000
0000000102000304110512101314152120222330310632ffda0008010100010502af2d5695cb5d26526ce5d7af51597af22a09996abbf1aea178c707337fa6eb
7a0b73ea42f9f6bc2db338bab55388bc6e341c7e34f6fc79edb8f3dab167b56346e130ccf65c5598bc7d78d67e9e62deb429d9dcdcabee7c44eb5b41e0cea82f
e5f168193fe8ec2389cff5b87fb39bbbf3d66769b982bdb2291aa8c1e19950bb1eea4d76389c2e6fa4cf0db1fa9ce9390b7cce401d0ed17e4f169b71f00c1e0c
36398c6eb1c7c3ec1e173c65e16e6ff4e5375aafa6c1779b15a24e213f10fa732916d194a68b9da70f9de93391c3afe9cf7d56ca1a5b88ad2ca1e995640338f4
e947d2dfcff418718cdce073fd462fe9cfb3ee8cc00bed16b5184ad70b854bea84f553b09dd67710b4cda45d466d268c99c6659c4cda6e4b2bee27713b4dcd89
b13719beccdb8b65f9c105b9165cd8f474984377dcdf954f835408b0148d7f90afcbdd64a33b2ae4e4b1fb5c38d768386b8cc3c6cfc756f702455c896ae96ea4
6a7c18287f36c53d2c3d71f27cc46d59735552a0dce3ff00e06364315c6b84f4f6c366e7c464ada3a56b2fed282cb120eb0d9d51722d8320c39680faca8c3954
439b54f5f5cb6faecacd8b3ad6d0e35261c1130686088ee816c46f0dcdc0e561b0c2e67dd2f6b02d64ec749f6cd88f5abcb53cbf1dee323b0eb9ca557334b4e4
7508c138dfe7c19d04d389b84fcf710dc04acb5a3a58a2d606b1c960ac1cb7193de38b9ef5c64f7bc09ef58f0729483ef16caf90e46d38eb94cb563574c2cb37
3e3c35353460b277967f31f1bcf643522e552f90130eae9e8717630f1c4f4f8f3c8a27934cf2699e5d027998c91b35046cdc833d466f9899d5c5bd1e6c78ee6e
6ccdec16962069d6043111a00c225b6082f58b6033737a9e609e66e7e49f93c3e2796860362c195608996a63d8e5aab3ecdf81f99a86a0604eb06a09a9d60dac
5bf5058ad3e3c373b426769b9b3e0c81a75759e75cb036fe9fecd6a0fa089f316c6116f9d819a9a3e3b80cdc30995b180fd0209a83e8d4226a76222d8606dc33
535e061319a7ffc40029110002020103030402020300000000000000010211031012131420210430314122324051425271ffda0008010301013f01e75b459059
50b244e58d8e71334d367a56a8f54ed32bd9c58b77c8b11b628b123d5cabc1063f5733abc875990eb6675923ac97f473a7f4473a5f44b2a6bdac3e116596633d
4cae4458f48c1cbe05e95ff90a38e3f08cb15fb445dd6597d88b2cb3e206577310f4f4f3db224a8911ff0051c6bb6cb2cb2cb225963647cb32ba88c43d22c8cb
7c2c648fdd595d97a5e965912d9bcdc6247a97f88fb704e9d13f0c9331ce9d0c631f7c74a2a8c534677e6bba24ff002858c6467ba23efbd13132cbbf04511c5c
96ce94e94dacd8cd8c51313fa322a6331ca98fbdca84c4597645511661f102f48e46998da912499e2bc11b26ace338f56cdcc7214af4cdfa98dfe3aa1310b241
7d9cd0fece7c7fd8b1d1ff0004e421c91bc721b1f91c46b47a58dd884c421116bec9414be096392d28a1c14858d0e28a4645e0b1fb5626290d9e4de5c5fc95ae
e1e48af937c5fd925e28716b4a36336338d9c6718e2977d965a290c64e7b476fe48cf69d448ea247348e591c9239246f917236c99c7238cd838b2bb28a1bd18f
4a286b4dc5eb456946d28a36238cd86c66dd1fbf5a5695a228da5e8fddb2fd9bfe4fffc400271100020201030305010101010000000000000102110312132110
3031042022415132714061ffda0008010201013f019fa66e64bd3325e9e42f4f33624912c523d2637147ac5f230aa5da9cabc0db63b12ae9815cac92349b66d2
364d9364a92fb256fc9cf6a4ad92545144f846055024210e5a4d6df81636fcb3f87a5f7631268d2513e59055148911e993f48cac4ccb1b565f6a86254868d232
ae5d18844910e1d084648e8976e86b8a1e2fc1c4998d7cafa3285d26ab921cab1232c3547b715cf4b387e4c985a22bd9432460953a174cd0d2fb504328aa272e
192969e0dc1e435a3711ad0e478766376ba648ea4557bd2b1aa20b828aa2465f06456c6868960543e04acc78235726648417831c8dc46ea2528485a0f81a50a0
38d74c5fd13fe855d19465f234c7063848795b3fd383511ff492ff00d28a170596722b39341b6cd2fecd2726a66b3273e08b6852470596597d71792bd898bd96
7c075fa3a18d53e95eca349a19a24478628d9b4cdb34234c4f81aa3fa5c054fc15d1f5a1a348e2fa210a3621ad46cc4d98fe9b31fd3661fa6d43f4d981b58cdb
c68bc68de88f39ba9fd8a66b2d76132cd46a2c691a0aaeb451c0ebaea685919b86b1648fd8e4bebda99e7ad96793495dab351657bafdb7d290e3daa1aff81c7b
147fffc40037100001020304080305090100000000000001000203112110223132041213203041517105618123339192a134404450627282b1d1e1ffda000801
0100063f02ca665652b036628de46ab1512478545576b1574ea8b5bf3599164591645902c817bb0aeb648b982a78520713bbf4dc9b96799f24760c97741e7373
e2b61f4aee3021e75dc737a84e6bacd471f671388544f2a6e39dd0296eed00b263109b337db43c329d10733357a96877533de2d4e866c13371f42811c222d98c
100534746efed982d0c71bcda70836caad935426cb9a975aee636b9a5399635d3ba6850703c09a701c954ad56299c56b72689a23a53708aa2f72f6508a94766a
29b44d652a8d280ab82a43430015ec6dd6d6a5ae76ccd55682d73bcd4f665642b2158aaaab66a90fe8a90dc7b291d0dcab064b0540aac0b2a92aacca86c9b5f5
1c955640561257627c56a8a96a93db3dcc563662b321227d148cfe3b955564c750ba85fed0aeaa8d3eaae43791d94e2682f1e6da2d6911e4f0b5ccbd13a2c8c8
d2da1b3c9557557184a996482241527c6d4eed2bed7f0615efe21ed08afc43bb4357745d31dfc153c374b3e8a70fc0e2cfd02bbe06ff009d4a1781fab9ca7a4b
2143fd2caabbae7f7bcbbfb5592af00a9c58a18cef5283585a02019a4ecc04369126eea1722b92e4b95b8aff008aec37395c820775388dd76f4064af35d0fb85
4703c19852598ac4aa2a99aad15372eae4ab6cc2bb10faabc26ab4536b95ec787457adc38375df70afe49fffc400281000030001030304020301010000000000
00011121314161105171208191a1b1c1d1e1f030f1ffda0008010100013f21350b67f11946af629e589cb0d081f4acc914840cd036363f53549a37b9ed0742d9
e0c759bac6d3c1a175adf8e8a2b47c1d90e30dbb3e0ffc01cc35bf88fd043766e9b0d8dfaf4e0e06f8285d2b3f22302d122bd28bb22e479a8adb2119c3656eca
70bd98d8fa31b2fa9b8a97ab4518af4e93ca159ccfd06f18572c323472e5c2f86216d32946c6fd7745a275309a2a63078105ee6226d8e84ea1f6b086e6658ca9
fa0084bd6fa6af819836dcc29c2d09794e8f83225facb4fb18a242e8f52b830431e0cc3178301a55a8bff1e56c15aa16bc19a7034b0cb2acaaf96265213a2d0c
4b69af49b2756a8eee784c5e9a5296a3928c2da0b29b753b2468b979c9f8fd0bbc4f725af495d188b04d56a1ca58b81b35f041265a68e53948ee41cc5b71a255
884c1806301d12d87f717baee3235941b99fd0584f032aa3a450d6178d847715eb0813685b98bf73f8cc6a19914d9b197535dd94eee4516a84eb44b0ab7b12ec
79379c8af2dab52376f68d207112435bd1de64a455e4d60909b20f818a310d01f608f7c2217bc93486bf9670508741b16bf186f59291865d19195028b2b1e9ba
c861b0740b3ca1bf94bb9a7b78b1cdae105ac41b6d77625c15ba34a8636868a3a411455e4677e84dbe45802a1acd72317f627da8e1468ecf71e97eaef23cab16
a269e4b5ca9cdb007a0978359f935135b27ec5e169921e40370a497217ba29065ca94d6b50e74dec7414cd062fd435ea9e4d29a0ccd42d7036af2356ccbe25c0
e32cb6fd0423aff8f8124c27a7bc099f426bf7326a2a5b90abadbeed3f826c2e025f26507ee37c96db35eff900ac4d5b1c1d092d887aa38b185387ba1a771ee6
a9fd1859181558e893171b3a256b125772824cad36ce61a1af8a33dd5ec7f9412fb7d1e1f92aad7e4e27b5185f14a1f7d21e4c1e95271feb22ef8f627956cc57
b929ca409cb0f28bd4c8f587d0471911453f229334e480d8c6c1c9c80d4744e2860778d0f413e469968124da57b8db6a36211f7583631db23169f03b81c8c98a
3268522b794f27784bb191289b1da44190c5f5cd121a73237664482920cfa0d2e8347a1c827dce00dc23d6e4904c793429204fa3a15137b928d223c1cb8878c3
a375a31a87ca141f507eb2b746ba309485d48592040c2d0be9d88431a8c21878e48fffda000c030100020003000000106b0631a8f6e44e0c76cfc6a197c34b9c
d5a5e0fb54038412dabf4d200da8ebcf66ea2642070e2ecb9e6ef3daaf46c64184b704900e32fd4ed133cd5d6d80b812412cbe809ae198e77100949233ff002e
20ddb23398c9b0917cb5da4fe182bd6b94f1d5ab100351287c7902e5b68139144dd8dc3e3dfbc7e8199d0098cd819fcd9cdd48ab2249280e782fc18ff9527a96
29a4292210f465cc52715aba0ea39c6ebfffc400271101010100020202010304030000000000010011213110415161207191f03081b1d1c1e1f1ffda00080103
01013f104389cc21c966bb8b6ddacdbb30e6e1760317682083f226bd220c3823aa4ead38b03fa0ff009f083a09fabc1fa37d65a708bdc374189867bb39820fcb
21cfe2c672e5900fd5f13966f2139790bd8fdce02e184441e37f003e0359e01702e4ce9c8e66d0fae3c5cd93bee548c266afa7fcda31820ba967f002116b1cae
5c401e28190d75f05360df682ce5bdd2504f71e0b2ccdf0d8847cc03a472e6757b9b1c1fa7efff0050b2596db9974cd62e4b9b74dc65294b2db6c30ca1b2cbe4
4c0b7112c96d89e3708f64e79653ee52cb2cb6db107cc11db166992afecff3f7956a1babebb1ec9336f6adf2571cf4ca665996d806b6c693e2316f81e27b2e27
df3fbc4610c28c4625c382f62678cfce4c08632d91c7814eed516ba5b08788d679e0e667cc46407d2c3d6ec246905c6cb4d5847521f5690c0507cc07b9c81663
a10cb0624b3af0294a224575e37773bee79e463d486a41f57c39f8eed92b64cb2db6cbe46123ede5053211d42e98e82dac664b938bb865bb0e522a771236dfe3
fead3ff1ff0057f2e7c1ab5768ce7af1b16c30afb453e47ac1acd36777399d38253d4bfa95f536c296deaf84c27647cdb21c42ecf036186356bc0bb2b94e4891
ebc0697dac3259b6885e00f86acbddadf56d90109ee594b2ccccc925996dbe0b3c02d41f3620b84060782ca6d999667c659e062134f231110c2b65999966dfe8
0c30dbe06186dbffc4002511010101000203000104020300000000000100111031214151a120618191b1d1c1e1f1ffda0008010201013f10eede090f86cde188
f522993dcc8e692bb9c16df12cf19659270fe33c87715e178409e6daf81ff5c06bb6036d03d36becfb6c7460fbac5870f1965924927058274c709b8fdff88c61
1f6ba664e8d58599e72cb2c9249b4f3fa20e05fd99fdff00d42110cf08009c5e3fd91b2db780b2cb2c9261f1c26cce08e118897cf01c3727e45e2d9cf32a1e9b
620820b2cb2c9274842e92463c30bf86e144125a31eac10e2ebbb20fb11041671964969772ed7a45b89642fde18390e9790f00bce9d30701071965925dec2d3d
465aca26c40fe5261b2e15a0dc9f00b098237252c6218638c25584cb1b133bb116c3a7db6794dff3e61acb6789312be7b00796cbdd9f6f1c09e586e9d41eac5b
3d65e1e5115347867833a3f69cee5f0caf575accfd96badbcbb82d59d3b0e6c1c3f90fa12f9914a60dd1bc935ead1eecedfb26b5f6bc026df0c2b82a19698585
90e5919a5911213de98888076cabb603a8b599fd5e4e136193931d3abc7026143f46c91a93c197af01f6ff008ff71ee7f25876fe4b07b3fbbc38fe565ece5384
895f778982cfc5ea58c2f58bcac1e0bacf51f68fb22d8c3ff75fbbf982f7f9b56afe63af927d30fa9ec43f4dfbad271e999725d8b320d9cee17636a7ee0bdcff
0036bd4bedc6c6a71df05e9c9d46f623ea2e4c16c84478eb852d8ec6c42a9da7e251df1bfa326ce0642f76271645bc1e235c78b3e43f6268cb4a489c6fe878ce
05267031c8f1bceb0c360c1271b6f19044ffc400261001000202010305000203000000000000010011213141516171108191a1b1c1e1d1f0f1ffda0008010100
013f106a73081d65206d754f9e528f6a31aa8a2417d25049ef0c54150cf760d9b8d3da69f12ff497a1083061b1dc4ea2a1babdc7d60e1e5f78b969955bb8c17c
acb2b91f134fd21e710016fb200a3e385383f69b3f8517b53f647b0a1e84b0b8b059901a9b0b2e817ea0bea420f58a4c3823486dfc8f7b6b65611c16e282ad41
19940776a3fb25a306218e8a7955411a7ba1a06ca6d7f04d18d4e0852ac688bd07d443d2e7a08075ac0f2d1f8ca2cd46d45cb20eb0ea2cf8c67f89627917bebe
aa0b187042585d2186a5dc2c05e652c28971c152e3858611136465f4192199999832e0c2b9ac4c7a49ceabfbb950b8fb6287494617479963f2574800f68ac954
09783a605f03907112399429a85b12565a615e6ce630c36f41a95a8b2e5c194a3a6fd414000f55b9bb0b1981613acc65db29de86f67f83efd16c4a48220950f5
a554099b5972455371298c1781e18004036730bc1bf55972e5cb9443a7de56098841cc5d79911e91f4e6acc5aa03f90fe7a54a8461182d89b65ce86c88ac30c8
962710ac42a5729c3e8692e2e22cbf51a0b0ccd9542cadc0c4036cca42a44a7c4bcd6c1b7eae5460cf6b81f16f79c28c18870d546bd23acdccb13307c59ab942
42df18cb2f1820de29e6186122303dc09c65bc23d6947183282b2f451084e2a5f8a9f76e2b35d6ae38b4d5e04afce655b61ae513f0fd967e5575d453f631516f
a06e2ba8e405e298e834be60758d11b85310e3710b2a106d48a8b5ce5091017820850bd584af37a038250c9e59596f726ea68f8ce66dd656058a7497b36d406e
1a45a95728226bd721cc1c415d8a5825059302b022e3761d0387bc52e2594ab58b51531a9530f78d4a08232c15fb91101744b218b788540f7a181e68f50f961b
bf662621fad162bb827544c5ae521f1a1a5ea092d4a4ea471431d259e9f80cc415172d6a16e501a5973f3a992b7804b4546570a2e2cfd90ce1e4e2c4bf8b9a97
8aadf785dd6bb12985f45e21535f2c3c08f0c7758f94e2bf12ed50ee131c55d897e308bb1fd4b6fcf65528176bde07af9a5e501ed0ce068e122ceed9f83679d4
6b0484094ecde6215300ad41d7fac4c933b6781b8a42f217e046258aacdbe496e20bb1b672d388e62054001cda95de51511558e3748665ca8cf4581969ced4f6
96590f78a6d5792e3fc119468afa89b9d8b648bb674da00d95e0b8ab869188f4bd40fdf68003e61d3460a2b59a8ad18ca6fd930ccbdc7e88a63c95fccb74bc0b
f6156475c2cd48991b175b90edbadb71e0081581c15742794109341b05e5d07b0cbe97b5ff00b595ed53722e09798bc63f0090b180f6250d08e82cb0643ce670
d18cb7c29cc23b12b657de39758e344c8103a071e61775a1ff00d599a4401dd36e4ed070095f113350f1275bf92a9156bfe728b1ef7fc41f47b7fa4ca01ef7fe
100cfe12ff006da75f88970b4ea2fc852a4e88fb86a7466d622be521be5ab98523ac7f0b21648ed4e52a591cd2d805f9964ca8e0b83e503d79966f50dc0bd26f
a83d1a96885ec6f8978b8b16912248d6b1122abc434dfd095a498e8c54ee864a3bd457b116f09ed2fb21c54ab168350ff12b27cebea53d81051043975300bb51
999345092c84f28330c75876435eb8260bc01e605c2e183044b8a60458c572e63c13da353dc403097c4a76107883c1021a22e6611790992753c896e44cf5aba9
1fa216094904236f31846e62ba865704e489c910b51299c4af5348458c449885f246505b4251fc881b090738778210c41070d44bc45e6386483d677263151c16
41ed0eb10c36466a0ed1259166a013094d88a6c83e210c4b2c6e12e67040992585826462a3ac5a84b89527ffd9}}}}}

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s2\ql\nowidctlpar\hyphpar0\sb200\sa120\keepn\ltrpar\cf17\b\dbch\af9\langfe2052\dbch\af13\afs32\alang1081\ab\loch\f4\fs32\lang1033{\listtext\pard\plain }\ilvl1\ls1 \li936\ri0\lin936\rin0\fi-576\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225{{\*\bkmkstart __DdeLink__109_736781840}\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af12\rtlch \ltrch\loch\fs21\loch\f8\hich\af8{\*\bkmkend __DdeLink__109_736781840}
Maecenas non lorem quis tellus placerat varius. Nulla facilisi. Aenean congue fringilla justo ut aliquam. Mauris id ex erat. Nunc vulputate neque vitae justo facilisis, non condimentum ante sagittis. Morbi viverra semper lorem nec molestie. Maecenas tincidunt est efficitur ligula euismod, sit amet ornare est vulputate.}
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af12\rtlch \ltrch\loch\fs21\loch\f8\hich\af8
In non mauris justo. Duis vehicula mi vel mi pretium, a viverra erat efficitur. Cras aliquam est ac eros varius, id iaculis dui auctor. Duis pretium neque ligula, et pulvinar mi placerat et. Nulla nec nunc sit amet nunc posuere vestibulum. Ut id neque eget tortor mattis tristique. Donec ante est, blandit sit amet tristique vel, lacinia pulvinar arcu. Pellentesque scelerisque fermentum erat, id posuere justo pulvinar ut. Cras id eros sed enim aliquam lobortis. Sed lobortis nisl ut eros efficitur tincidunt. Cras justo mi, porttitor quis mattis vel, ultricies ut purus. Ut facilisis et lacus eu cursus.}{\rtlch \ltrch\loch
In eleifend velit vitae libero sollicitudin euismod. }
\par \shpwr2\shpwrk3\shpbypara\shpbyignore\shptop0\shpbxcolumn\shpbxignore\shpleft2819\pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch
{\*\flymaincnt5\flyanchor0\flycntnt}{\shp{\*\shpinst\shpwr2\shpwrk3\shpbypara\shpbyignore\shptop0\shpbottom2660\shpbxcolumn\shpbxignore\shpleft2819\shpright6819{\sp{\sn shapeType}{\sv 75}}{\sp{\sn wzDescription}{\sv }}{\sp{\sn wzName}{\sv }}{\sp{\sn pib}{\sv {\pict\picscalex100\picscaley100\piccropl0\piccropr0\piccropt0\piccropb0\picw200\pich133\picwgoal4000\pichgoal2660\jpegblip
ffd8ffe000104a46494600010101004800480000ffe20c584943435f50524f46494c4500010100000c484c696e6f021000006d6e74725247422058595a2007ce
00020009000600310000616373704d5346540000000049454320735247420000000000000000000000000000f6d6000100000000d32d48502020000000000000
00000000000000000000000000000000000000000000000000000000000000000000000000000000001163707274000001500000003364657363000001840000
006c77747074000001f000000014626b707400000204000000147258595a00000218000000146758595a0000022c000000146258595a0000024000000014646d
6e640000025400000070646d6464000002c400000088767565640000034c0000008676696577000003d4000000246c756d69000003f8000000146d6561730000
040c0000002474656368000004300000000c725452430000043c0000080c675452430000043c0000080c625452430000043c0000080c7465787400000000436f
70797269676874202863292031393938204865776c6574742d5061636b61726420436f6d70616e79000064657363000000000000001273524742204945433631
3936362d322e31000000000000000000000012735247422049454336313936362d322e3100000000000000000000000000000000000000000000000000000000
0000000000000000000000000000000000000000000058595a20000000000000f35100010000000116cc58595a20000000000000000000000000000000005859
5a200000000000006fa2000038f50000039058595a2000000000000062990000b785000018da58595a2000000000000024a000000f840000b6cf646573630000
00000000001649454320687474703a2f2f7777772e6965632e636800000000000000000000001649454320687474703a2f2f7777772e6965632e636800000000
00000000000000000000000000000000000000000000000000000000000000000000000000000000000064657363000000000000002e4945432036313936362d
322e312044656661756c742052474220636f6c6f7572207370616365202d207352474200000000000000000000002e4945432036313936362d322e3120446566
61756c742052474220636f6c6f7572207370616365202d20735247420000000000000000000000000000000000000000000064657363000000000000002c5265
666572656e63652056696577696e6720436f6e646974696f6e20696e2049454336313936362d322e3100000000000000000000002c5265666572656e63652056
696577696e6720436f6e646974696f6e20696e2049454336313936362d322e310000000000000000000000000000000000000000000000000000766965770000
00000013a4fe00145f2e0010cf140003edcc0004130b00035c9e0000000158595a2000000000004c09560050000000571fe76d65617300000000000000010000
00000000000000000000000000000000028f0000000273696720000000004352542063757276000000000000040000000005000a000f00140019001e00230028
002d00320037003b00400045004a004f00540059005e00630068006d00720077007c00810086008b00900095009a009f00a400a900ae00b200b700bc00c100c6
00cb00d000d500db00e000e500eb00f000f600fb01010107010d01130119011f0125012b01320138013e0145014c0152015901600167016e0175017c0183018b
0192019a01a101a901b101b901c101c901d101d901e101e901f201fa0203020c0214021d0226022f02380241024b0254025d02670271027a0284028e029802a2
02ac02b602c102cb02d502e002eb02f50300030b03160321032d03380343034f035a03660372037e038a039603a203ae03ba03c703d303e003ec03f904060413
0420042d043b0448045504630471047e048c049a04a804b604c404d304e104f004fe050d051c052b053a05490558056705770586059605a605b505c505d505e5
05f6060606160627063706480659066a067b068c069d06af06c006d106e306f507070719072b073d074f076107740786079907ac07bf07d207e507f8080b081f
08320846085a086e0882089608aa08be08d208e708fb09100925093a094f09640979098f09a409ba09cf09e509fb0a110a270a3d0a540a6a0a810a980aae0ac5
0adc0af30b0b0b220b390b510b690b800b980bb00bc80be10bf90c120c2a0c430c5c0c750c8e0ca70cc00cd90cf30d0d0d260d400d5a0d740d8e0da90dc30dde
0df80e130e2e0e490e640e7f0e9b0eb60ed20eee0f090f250f410f5e0f7a0f960fb30fcf0fec1009102610431061107e109b10b910d710f511131131114f116d
118c11aa11c911e81207122612451264128412a312c312e31303132313431363138313a413c513e5140614271449146a148b14ad14ce14f01512153415561578
159b15bd15e0160316261649166c168f16b216d616fa171d17411765178917ae17d217f7181b18401865188a18af18d518fa19201945196b199119b719dd1a04
1a2a1a511a771a9e1ac51aec1b141b3b1b631b8a1bb21bda1c021c2a1c521c7b1ca31ccc1cf51d1e1d471d701d991dc31dec1e161e401e6a1e941ebe1ee91f13
1f3e1f691f941fbf1fea20152041206c209820c420f0211c2148217521a121ce21fb22272255228222af22dd230a23382366239423c223f0241f244d247c24ab
24da250925382568259725c725f726272657268726b726e827182749277a27ab27dc280d283f287128a228d429062938296b299d29d02a022a352a682a9b2acf
2b022b362b692b9d2bd12c052c392c6e2ca22cd72d0c2d412d762dab2de12e162e4c2e822eb72eee2f242f5a2f912fc72ffe3035306c30a430db3112314a3182
31ba31f2322a3263329b32d4330d3346337f33b833f1342b3465349e34d83513354d358735c235fd3637367236ae36e937243760379c37d738143850388c38c8
39053942397f39bc39f93a363a743ab23aef3b2d3b6b3baa3be83c273c653ca43ce33d223d613da13de03e203e603ea03ee03f213f613fa23fe24023406440a6
40e74129416a41ac41ee4230427242b542f7433a437d43c044034447448a44ce45124555459a45de4622466746ab46f04735477b47c04805484b489148d7491d
496349a949f04a374a7d4ac44b0c4b534b9a4be24c2a4c724cba4d024d4a4d934ddc4e254e6e4eb74f004f494f934fdd5027507150bb51065150519b51e65231
527c52c75313535f53aa53f65442548f54db5528557555c2560f565c56a956f75744579257e0582f587d58cb591a596959b85a075a565aa65af55b455b955be5
5c355c865cd65d275d785dc95e1a5e6c5ebd5f0f5f615fb36005605760aa60fc614f61a261f56249629c62f06343639763eb6440649464e9653d659265e7663d
669266e8673d679367e9683f689668ec6943699a69f16a486a9f6af76b4f6ba76bff6c576caf6d086d606db96e126e6b6ec46f1e6f786fd1702b708670e0713a
719571f0724b72a67301735d73b87414747074cc7528758575e1763e769b76f8775677b37811786e78cc792a798979e77a467aa57b047b637bc27c217c817ce1
7d417da17e017e627ec27f237f847fe5804780a8810a816b81cd8230829282f4835783ba841d848084e3854785ab860e867286d7873b879f8804886988ce8933
899989fe8a648aca8b308b968bfc8c638cca8d318d988dff8e668ece8f368f9e9006906e90d6913f91a89211927a92e3934d93b69420948a94f4955f95c99634
969f970a977597e0984c98b89924999099fc9a689ad59b429baf9c1c9c899cf79d649dd29e409eae9f1d9f8b9ffaa069a0d8a147a1b6a226a296a306a376a3e6
a456a4c7a538a5a9a61aa68ba6fda76ea7e0a852a8c4a937a9a9aa1caa8fab02ab75abe9ac5cacd0ad44adb8ae2daea1af16af8bb000b075b0eab160b1d6b24b
b2c2b338b3aeb425b49cb513b58ab601b679b6f0b768b7e0b859b8d1b94ab9c2ba3bbab5bb2ebba7bc21bc9bbd15bd8fbe0abe84beffbf7abff5c070c0ecc167
c1e3c25fc2dbc358c3d4c451c4cec54bc5c8c646c6c3c741c7bfc83dc8bcc93ac9b9ca38cab7cb36cbb6cc35ccb5cd35cdb5ce36ceb6cf37cfb8d039d0bad13c
d1bed23fd2c1d344d3c6d449d4cbd54ed5d1d655d6d8d75cd7e0d864d8e8d96cd9f1da76dafbdb80dc05dc8add10dd96de1cdea2df29dfafe036e0bde144e1cc
e253e2dbe363e3ebe473e4fce584e60de696e71fe7a9e832e8bce946e9d0ea5beae5eb70ebfbec86ed11ed9cee28eeb4ef40efccf058f0e5f172f1fff28cf319
f3a7f434f4c2f550f5def66df6fbf78af819f8a8f938f9c7fa57fae7fb77fc07fc98fd29fdbafe4bfedcff6dffffffdb00430005040404040305040404060505
06080d0808070708100b0c090d131014131210121214171d1914161c1612121a231a1c1e1f212121141924272420261d202120ffdb0043010506060807080f08
080f201512152020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020ffc2001108008500
c803011100021101031101ffc4001c0000010501010100000000000000000000020001030405060708ffc4001a01000301010101000000000000000000000102
0300040506ffda000c03010002100310000001cef90fb09a72952d6a75cbea4d4e63c8fb5e46b47b7ac13eefbbc600d1ab0076056ce0100416acafcf72f764c5
b2c88cb7775e3dda7264f5754ed3360db03601aa1102d6c81bcfca398411c56ce32d9d4101c847bb834e8bbcea88916beadd3e3db6907534b4989384bd3c6b57
b1dcfd09846af1ab3660044e582d96ce0b8c977982f6f3d37b5257036b9fabd4fd0f0a4558fa5e5acf3a5d3e2d4eecbbc3604bdbb9a4db0e6118183157c160f8
ac5d5a347f15a74410725d6263afe6eaf48eef09d7074996aa0a7cea3eb705d52c4e9e4f68e0af54a83b33289472ae558e432c5c3514af8776343ced624d7f9f
a3d1a27b2b798614fb94983918fcddbe1fd74c0e9e4d74deede75e4647644513222110b640a0d842bc5deb940e0149f97b7dab8d374f1985b3e945d821a0957c
a376f95fa3c359e5ed1e7f5773006e8e5132b156216c81607917b60d2a294e7185b8dbd53cdbc926255e8bdaf1d6c2a6347c89f57cf3ea72e3db9b690fbf799d
368cdd95ca265121608e056f34e8b516a62837675ea796fa5e67a4b9fa6ca6f41fa7f91e7bccf5f3d9f03ba16d27c2d5312d0b197b291d645264e9d652ba065a
6af66b2a894f30e8e9c12dae94b894e8b92d67cef4adcab6267b3f67e7208d2bad7396f84dabbcb61277424f49d5a2d869a74074899200d18311192691ea47a9
5453a1e6b75ca97edcd61e3ccf93ee36c8e00d09d1b4e85a117571eaa248c8656ab2e55467d044da33a326916bd36d293cf3aef21e9001471538fc3e857d5061
015379d829436c2eff003e769c84390442da26d20d608ead92cbeb20a9b20c4ac919908ccf21e7fbce529d6557a79bb6bf0d20451dcace54ca995321c81d9308
b1a28d9aadaef3d1759f31024aee19d779d799ee994ad49e7d274a9372b6996f64be8b7535802719f013a225866d9d73111632309e82d93054684df84e1f55ca
46c80c88a8b2d8cb315972332915b886da9914b6cfb2c61c63c50cc0be311780b366c74acd95ca8b21e05945d642b3653c0b006d19138d710ce8c810c6224766
0483163097af9b9971a73d2e08a8b2cb84a01b239078160632d85b44c076b2bae4d9958098f173833572f51cff00ffc400271000020202020005050101000000
0000000102000304110512101314152120222330310632ffda0008010100010502af2d5695cb5d26526ce5d7af51597af22a09996abbf1aea178c707337fa6eb
7a0b73ea42f9f6bc2db338bab55388bc6e341c7e34f6fc79edb8f3dab167b56346e130ccf65c5598bc7d78d67e9e62deb429d9dcdcabee7c44eb5b41e0cea82f
e5f168193fe8ec2389cff5b87fb39bbbf3d66769b982bdb2291aa8c1e19950bb1eea4d76389c2e6fa4cf0db1fa9ce9390b7cce401d0ed17e4f169b71f00c1e0c
36398c6eb1c7c3ec1e173c65e16e6ff4e5375aafa6c1779b15a24e213f10fa732916d194a68b9da70f9de93391c3afe9cf7d56ca1a5b88ad2ca1e995640338f4
e947d2dfcff418718cdce073fd462fe9cfb3ee8cc00bed16b5184ad70b854bea84f553b09dd67710b4cda45d466d268c99c6659c4cda6e4b2bee27713b4dcd89
b13719beccdb8b65f9c105b9165cd8f474984377dcdf954f835408b0148d7f90afcbdd64a33b2ae4e4b1fb5c38d768386b8cc3c6cfc756f702455c896ae96ea4
6a7c18287f36c53d2c3d71f27cc46d59735552a0dce3ff00e06364315c6b84f4f6c366e7c464ada3a56b2fed282cb120eb0d9d51722d8320c39680faca8c3954
439b54f5f5cb6faecacd8b3ad6d0e35261c1130686088ee816c46f0dcdc0e561b0c2e67dd2f6b02d64ec749f6cd88f5abcb53cbf1dee323b0eb9ca557334b4e4
7508c138dfe7c19d04d389b84fcf710dc04acb5a3a58a2d606b1c960ac1cb7193de38b9ef5c64f7bc09ef58f0729483ef16caf90e46d38eb94cb563574c2cb37
3e3c35353460b277967f31f1bcf643522e552f90130eae9e8717630f1c4f4f8f3c8a27934cf2699e5d027998c91b35046cdc833d466f9899d5c5bd1e6c78ee6e
6ccdec16962069d6043111a00c225b6082f58b6033737a9e609e66e7e49f93c3e2796860362c195608996a63d8e5aab3ecdf81f99a86a0604eb06a09a9d60dac
5bf5058ad3e3c373b426769b9b3e0c81a75759e75cb036fe9fecd6a0fa089f316c6116f9d819a9a3e3b80cdc30995b180fd0209a83e8d4226a76222d8606dc33
535e061319a7ffc40029110002020103030402020300000000000000010211031012131420210430314122324051425271ffda0008010301013f01e75b459059
50b244e58d8e71334d367a56a8f54ed32bd9c58b77c8b11b628b123d5cabc1063f5733abc875990eb6675923ac97f473a7f4473a5f44b2a6bdac3e116596633d
4cae4458f48c1cbe05e95ff90a38e3f08cb15fb445dd6597d88b2cb3e206577310f4f4f3db224a8911ff0051c6bb6cb2cb2cb225963647cb32ba88c43d22c8cb
7c2c648fdd595d97a5e965912d9bcdc6247a97f88fb704e9d13f0c9331ce9d0c631f7c74a2a8c534677e6bba24ff002858c6467ba23efbd13132cbbf04511c5c
96ce94e94dacd8cd8c51313fa322a6331ca98fbdca84c4597645511661f102f48e46998da912499e2bc11b26ace338f56cdcc7214af4cdfa98dfe3aa1310b241
7d9cd0fece7c7fd8b1d1ff0004e421c91bc721b1f91c46b47a58dd884c421116bec9414be096392d28a1c14858d0e28a4645e0b1fb5626290d9e4de5c5fc95ae
e1e48af937c5fd925e28716b4a36336338d9c6718e2977d965a290c64e7b476fe48cf69d448ea247348e591c9239246f917236c99c7238cd838b2bb28a1bd18f
4a286b4dc5eb456946d28a36238cd86c66dd1fbf5a5695a228da5e8fddb2fd9bfe4fffc400271100020201030305010101010000000000000102110312132110
3031042022415132714061ffda0008010201013f019fa66e64bd3325e9e42f4f33624912c523d2637147ac5f230aa5da9cabc0db63b12ae9815cac92349b66d2
364d9364a92fb256fc9cf6a4ad92545144f846055024210e5a4d6df81636fcb3f87a5f7631268d2513e59055148911e993f48cac4ccb1b565f6a86254868d232
ae5d18844910e1d084648e8976e86b8a1e2fc1c4998d7cafa3285d26ab921cab1232c3547b715cf4b387e4c985a22bd9432460953a174cd0d2fb504328aa272e
192969e0dc1e435a3711ad0e478766376ba648ea4557bd2b1aa20b828aa2465f06456c6868960543e04acc78235726648417831c8dc46ea2528485a0f81a50a0
38d74c5fd13fe855d19465f234c7063848795b3fd383511ff492ff00d28a170596722b39341b6cd2fecd2726a66b3273e08b6852470596597d71792bd898bd96
7c075fa3a18d53e95eca349a19a24478628d9b4cdb34234c4f81aa3fa5c054fc15d1f5a1a348e2fa210a3621ad46cc4d98fe9b31fd3661fa6d43f4d981b58cdb
c68bc68de88f39ba9fd8a66b2d76132cd46a2c691a0aaeb451c0ebaea685919b86b1648fd8e4bebda99e7ad96793495dab351657bafdb7d290e3daa1aff81c7b
147fffc40037100001020304080305090100000000000001000203112110223132041213203041517105618123339192a134404450627282b1d1e1ffda000801
0100063f02ca665652b036628de46ab1512478545576b1574ea8b5bf3599164591645902c817bb0aeb648b982a78520713bbf4dc9b96799f24760c97741e7373
e2b61f4aee3021e75dc737a84e6bacd471f671388544f2a6e39dd0296eed00b263109b337db43c329d10733357a96877533de2d4e866c13371f42811c222d98c
100534746efed982d0c71bcda70836caad935426cb9a975aee636b9a5399635d3ba6850703c09a701c954ad56299c56b72689a23a53708aa2f72f6508a94766a
29b44d652a8d280ab82a43430015ec6dd6d6a5ae76ccd55682d73bcd4f665642b2158aaaab66a90fe8a90dc7b291d0dcab064b0540aac0b2a92aacca86c9b5f5
1c955640561257627c56a8a96a93db3dcc563662b321227d148cfe3b955564c750ba85fed0aeaa8d3eaae43791d94e2682f1e6da2d6911e4f0b5ccbd13a2c8c8
d2da1b3c9557557184a996482241527c6d4eed2bed7f0615efe21ed08afc43bb4357745d31dfc153c374b3e8a70fc0e2cfd02bbe06ff009d4a1781fab9ca7a4b
2143fd2caabbae7f7bcbbfb5592af00a9c58a18cef5283585a02019a4ecc04369126eea1722b92e4b95b8aff008aec37395c820775388dd76f4064af35d0fb85
4703c19852598ac4aa2a99aad15372eae4ab6cc2bb10faabc26ab4536b95ec787457adc38375df70afe49fffc400281000030001030304020301010000000000
00011121314161105171208191a1b1c1d1e1f030f1ffda0008010100013f21350b67f11946af629e589cb0d081f4acc914840cd036363f53549a37b9ed0742d9
e0c759bac6d3c1a175adf8e8a2b47c1d90e30dbb3e0ffc01cc35bf88fd043766e9b0d8dfaf4e0e06f8285d2b3f22302d122bd28bb22e479a8adb2119c3656eca
70bd98d8fa31b2fa9b8a97ab4518af4e93ca159ccfd06f18572c323472e5c2f86216d32946c6fd7745a275309a2a63078105ee6226d8e84ea1f6b086e6658ca9
fa0084bd6fa6af819836dcc29c2d09794e8f83225facb4fb18a242e8f52b830431e0cc3178301a55a8bff1e56c15aa16bc19a7034b0cb2acaaf96265213a2d0c
4b69af49b2756a8eee784c5e9a5296a3928c2da0b29b753b2468b979c9f8fd0bbc4f725af495d188b04d56a1ca58b81b35f041265a68e53948ee41cc5b71a255
884c1806301d12d87f717baee3235941b99fd0584f032aa3a450d6178d847715eb0813685b98bf73f8cc6a19914d9b197535dd94eee4516a84eb44b0ab7b12ec
79379c8af2dab52376f68d207112435bd1de64a455e4d60909b20f818a310d01f608f7c2217bc93486bf9670508741b16bf186f59291865d19195028b2b1e9ba
c861b0740b3ca1bf94bb9a7b78b1cdae105ac41b6d77625c15ba34a8636868a3a411455e4677e84dbe45802a1acd72317f627da8e1468ecf71e97eaef23cab16
a269e4b5ca9cdb007a0978359f935135b27ec5e169921e40370a497217ba29065ca94d6b50e74dec7414cd062fd435ea9e4d29a0ccd42d7036af2356ccbe25c0
e32cb6fd0423aff8f8124c27a7bc099f426bf7326a2a5b90abadbeed3f826c2e025f26507ee37c96db35eff900ac4d5b1c1d092d887aa38b185387ba1a771ee6
a9fd1859181558e893171b3a256b125772824cad36ce61a1af8a33dd5ec7f9412fb7d1e1f92aad7e4e27b5185f14a1f7d21e4c1e95271feb22ef8f627956cc57
b929ca409cb0f28bd4c8f587d0471911453f229334e480d8c6c1c9c80d4744e2860778d0f413e469968124da57b8db6a36211f7583631db23169f03b81c8c98a
3268522b794f27784bb191289b1da44190c5f5cd121a73237664482920cfa0d2e8347a1c827dce00dc23d6e4904c793429204fa3a15137b928d223c1cb8878c3
a375a31a87ca141f507eb2b746ba309485d48592040c2d0be9d88431a8c21878e48fffda000c030100020003000000106b0631a8f6e44e0c76cfc6a197c34b9c
d5a5e0fb54038412dabf4d200da8ebcf66ea2642070e2ecb9e6ef3daaf46c64184b704900e32fd4ed133cd5d6d80b812412cbe809ae198e77100949233ff002e
20ddb23398c9b0917cb5da4fe182bd6b94f1d5ab100351287c7902e5b68139144dd8dc3e3dfbc7e8199d0098cd819fcd9cdd48ab2249280e782fc18ff9527a96
29a4292210f465cc52715aba0ea39c6ebfffc400271101010100020202010304030000000000010011213110415161207191f03081b1d1c1e1f1ffda00080103
01013f104389cc21c966bb8b6ddacdbb30e6e1760317682083f226bd220c3823aa4ead38b03fa0ff009f083a09fabc1fa37d65a708bdc374189867bb39820fcb
21cfe2c672e5900fd5f13966f2139790bd8fdce02e184441e37f003e0359e01702e4ce9c8e66d0fae3c5cd93bee548c266afa7fcda31820ba967f002116b1cae
5c401e28190d75f05360df682ce5bdd2504f71e0b2ccdf0d8847cc03a472e6757b9b1c1fa7efff0050b2596db9974cd62e4b9b74dc65294b2db6c30ca1b2cbe4
4c0b7112c96d89e3708f64e79653ee52cb2cb6db107cc11db166992afecff3f7956a1babebb1ec9336f6adf2571cf4ca665996d806b6c693e2316f81e27b2e27
df3fbc4610c28c4625c382f62678cfce4c08632d91c7814eed516ba5b08788d679e0e667cc46407d2c3d6ec246905c6cb4d5847521f5690c0507cc07b9c81663
a10cb0624b3af0294a224575e37773bee79e463d486a41f57c39f8eed92b64cb2db6cbe46123ede5053211d42e98e82dac664b938bb865bb0e522a771236dfe3
fead3ff1ff0057f2e7c1ab5768ce7af1b16c30afb453e47ac1acd36777399d38253d4bfa95f536c296deaf84c27647cdb21c42ecf036186356bc0bb2b94e4891
ebc0697dac3259b6885e00f86acbddadf56d90109ee594b2ccccc925996dbe0b3c02d41f3620b84060782ca6d999667c659e062134f231110c2b65999966dfe8
0c30dbe06186dbffc4002511010101000203000104020300000000000100111031214151a120618191b1d1c1e1f1ffda0008010201013f10eede090f86cde188
f522993dcc8e692bb9c16df12cf19659270fe33c87715e178409e6daf81ff5c06bb6036d03d36becfb6c7460fbac5870f1965924927058274c709b8fdff88c61
1f6ba664e8d58599e72cb2c9249b4f3fa20e05fd99fdff00d42110cf08009c5e3fd91b2db780b2cb2c9261f1c26cce08e118897cf01c3727e45e2d9cf32a1e9b
620820b2cb2c9274842e92463c30bf86e144125a31eac10e2ebbb20fb11041671964969772ed7a45b89642fde18390e9790f00bce9d30701071965925dec2d3d
465aca26c40fe5261b2e15a0dc9f00b098237252c6218638c25584cb1b133bb116c3a7db6794dff3e61acb6789312be7b00796cbdd9f6f1c09e586e9d41eac5b
3d65e1e5115347867833a3f69cee5f0caf575accfd96badbcbb82d59d3b0e6c1c3f90fa12f9914a60dd1bc935ead1eecedfb26b5f6bc026df0c2b82a19698585
90e5919a5911213de98888076cabb603a8b599fd5e4e136193931d3abc7026143f46c91a93c197af01f6ff008ff71ee7f25876fe4b07b3fbbc38fe565ece5384
895f778982cfc5ea58c2f58bcac1e0bacf51f68fb22d8c3ff75fbbf982f7f9b56afe63af927d30fa9ec43f4dfbad271e999725d8b320d9cee17636a7ee0bdcff
0036bd4bedc6c6a71df05e9c9d46f623ea2e4c16c84478eb852d8ec6c42a9da7e251df1bfa326ce0642f76271645bc1e235c78b3e43f6268cb4a489c6fe878ce
05267031c8f1bceb0c360c1271b6f19044ffc400261001000202010305000203000000000000010011213141516171108191a1b1c1e1d1f0f1ffda0008010100
013f106a73081d65206d754f9e528f6a31aa8a2417d25049ef0c54150cf760d9b8d3da69f12ff497a1083061b1dc4ea2a1babdc7d60e1e5f78b969955bb8c17c
acb2b91f134fd21e710016fb200a3e385383f69b3f8517b53f647b0a1e84b0b8b059901a9b0b2e817ea0bea420f58a4c3823486dfc8f7b6b65611c16e282ad41
19940776a3fb25a306218e8a7955411a7ba1a06ca6d7f04d18d4e0852ac688bd07d443d2e7a08075ac0f2d1f8ca2cd46d45cb20eb0ea2cf8c67f89627917bebe
aa0b187042585d2186a5dc2c05e652c28971c152e3858611136465f4192199999832e0c2b9ac4c7a49ceabfbb950b8fb6287494617479963f2574800f68ac954
09783a605f03907112399429a85b12565a615e6ce630c36f41a95a8b2e5c194a3a6fd414000f55b9bb0b1981613acc65db29de86f67f83efd16c4a48220950f5
a554099b5972455371298c1781e18004036730bc1bf55972e5cb9443a7de56098841cc5d79911e91f4e6acc5aa03f90fe7a54a8461182d89b65ce86c88ac30c8
962710ac42a5729c3e8692e2e22cbf51a0b0ccd9542cadc0c4036cca42a44a7c4bcd6c1b7eae5460cf6b81f16f79c28c18870d546bd23acdccb13307c59ab942
42df18cb2f1820de29e6186122303dc09c65bc23d6947183282b2f451084e2a5f8a9f76e2b35d6ae38b4d5e04afce655b61ae513f0fd967e5575d453f631516f
a06e2ba8e405e298e834be60758d11b85310e3710b2a106d48a8b5ce5091017820850bd584af37a038250c9e59596f726ea68f8ce66dd656058a7497b36d406e
1a45a95728226bd721cc1c415d8a5825059302b022e3761d0387bc52e2594ab58b51531a9530f78d4a08232c15fb91101744b218b788540f7a181e68f50f961b
bf662621fad162bb827544c5ae521f1a1a5ea092d4a4ea471431d259e9f80cc415172d6a16e501a5973f3a992b7804b4546570a2e2cfd90ce1e4e2c4bf8b9a97
8aadf785dd6bb12985f45e21535f2c3c08f0c7758f94e2bf12ed50ee131c55d897e308bb1fd4b6fcf65528176bde07af9a5e501ed0ce068e122ceed9f83679d4
6b0484094ecde6215300ad41d7fac4c933b6781b8a42f217e046258aacdbe496e20bb1b672d388e62054001cda95de51511558e3748665ca8cf4581969ced4f6
96590f78a6d5792e3fc119468afa89b9d8b648bb674da00d95e0b8ab869188f4bd40fdf68003e61d3460a2b59a8ad18ca6fd930ccbdc7e88a63c95fccb74bc0b
f6156475c2cd48991b175b90edbadb71e0081581c15742794109341b05e5d07b0cbe97b5ff00b595ed53722e09798bc63f0090b180f6250d08e82cb0643ce670
d18cb7c29cc23b12b657de39758e344c8103a071e61775a1ff00d599a4401dd36e4ed070095f113350f1275bf92a9156bfe728b1ef7fc41f47b7fa4ca01ef7fe
100cfe12ff006da75f88970b4ea2fc852a4e88fb86a7466d622be521be5ab98523ac7f0b21648ed4e52a591cd2d805f9964ca8e0b83e503d79966f50dc0bd26f
a83d1a96885ec6f8978b8b16912248d6b1122abc434dfd095a498e8c54ee864a3bd457b116f09ed2fb21c54ab168350ff12b27cebea53d81051043975300bb51
999345092c84f28330c75876435eb8260bc01e605c2e183044b8a60458c572e63c13da353dc403097c4a76107883c1021a22e6611790992753c896e44cf5aba9
1fa216094904236f31846e62ba865704e489c910b51299c4af5348458c449885f246505b4251fc881b090738778210c41070d44bc45e6386483d677263151c16
41ed0eb10c36466a0ed1259166a013094d88a6c83e210c4b2c6e12e67040992585826462a3ac5a84b89527ffd9}}}}}

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af12\rtlch \ltrch\loch\fs21\loch\f8\hich\af8
Fusce vitae vestibulum velit. Pellentesque vulputate lectus quis pellentesque commodo. Aliquam erat volutpat. Vestibulum in egestas velit. Pellentesque fermentum nisl vitae fringilla venenatis. Etiam id mauris vitae orci maximus ultricies. Cras fringilla ipsum magna, in fringilla dui commodo a.}
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af12\rtlch \ltrch\loch\fs21\loch\f8\hich\af8
Etiam vehicula luctus fermentum. In vel metus congue, pulvinar lectus vel, fermentum dui. Maecenas ante orci, egestas ut aliquet sit amet, sagittis a magna. Aliquam ante quam, pellentesque ut dignissim quis, laoreet eget est. Aliquam erat volutpat. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Ut ullamcorper justo sapien, in cursus libero viverra eget. Vivamus auctor imperdiet urna, at pulvinar leo posuere laoreet. Suspendisse neque nisl, fringilla at iaculis scelerisque, ornare vel dolor. Ut et pulvinar nunc. Pellentesque fringilla mollis efficitur. Nullam venenatis commodo imperdiet. Morbi velit neque, semper quis lorem quis, efficitur dignissim ipsum. Ut ac lorem sed turpis imperdiet eleifend sit amet id sapien.}
\par \pard\plain \s1\ql\nowidctlpar\hyphpar0\sb240\sa120\keepn\ltrpar\cf17\b\dbch\af9\langfe2052\dbch\af13\afs36\alang1081\ab\loch\f4\fs36\lang1033{\listtext\pard\plain }\ilvl0\ls1 \li792\ri0\lin792\rin0\fi-432{\rtlch \ltrch\loch
Lorem ipsum dolor sit amet, consectetur adipiscing elit. }
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af12\rtlch \ltrch\loch\fs21\loch\f8\hich\af8

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af12\rtlch \ltrch\loch\fs21\loch\f8\hich\af8
Nunc ac faucibus odio. Vestibulum neque massa, scelerisque sit amet ligula eu, congue molestie mi. Praesent ut varius sem. Nullam at porttitor arcu, nec lacinia nisi. Ut ac dolor vitae odio interdum condimentum. Vivamus dapibus sodales ex, vitae malesuada ipsum cursus convallis. Maecenas sed egestas nulla, ac condimentum orci. Mauris diam felis, vulputate ac suscipit et, iaculis non est. Curabitur semper arcu ac ligula semper, nec luctus nisl blandit. Integer lacinia ante ac libero lobortis imperdiet. Nullam mollis convallis ipsum, ac accumsan nunc vehicula vitae. Nulla eget justo in felis tristique fringilla. Morbi sit amet tortor quis risus auctor condimentum. Morbi in ullamcorper elit. Nulla iaculis tellus sit amet mauris tempus fringilla.}
\par \pard\plain \s2\ql\nowidctlpar\hyphpar0\sb200\sa120\keepn\ltrpar\cf17\b\dbch\af9\langfe2052\dbch\af13\afs32\alang1081\ab\loch\f4\fs32\lang1033{\listtext\pard\plain }\ilvl1\ls1 \li936\ri0\lin936\rin0\fi-576{\rtlch \ltrch\loch
Maecenas mauris lectus, lobortis et purus mattis, blandit dictum tellus. }
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af12\rtlch \ltrch\loch\fs21\loch\f8\hich\af8
Maecenas non lorem quis tellus placerat varius. Nulla facilisi. Aenean congue fringilla justo ut aliquam. Mauris id ex erat. Nunc vulputate neque vitae justo facilisis, non condimentum ante sagittis. Morbi viverra semper lorem nec molestie. Maecenas tincidunt est efficitur ligula euismod, sit amet ornare est vulputate.}
\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \shpwr2\shpwrk3\shpbypara\shpbyignore\shptop0\shpbxcolumn\shpbxignore\shpleft2819\pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch
{\*\flymaincnt5\flyanchor0\flycntnt}{\shp{\*\shpinst\shpwr2\shpwrk3\shpbypara\shpbyignore\shptop0\shpbottom2660\shpbxcolumn\shpbxignore\shpleft2819\shpright6819{\sp{\sn shapeType}{\sv 75}}{\sp{\sn wzDescription}{\sv }}{\sp{\sn wzName}{\sv }}{\sp{\sn pib}{\sv {\pict\picscalex100\picscaley100\piccropl0\piccropr0\piccropt0\piccropb0\picw200\pich133\picwgoal4000\pichgoal2660\jpegblip
ffd8ffe000104a46494600010101004800480000ffe20c584943435f50524f46494c4500010100000c484c696e6f021000006d6e74725247422058595a2007ce
00020009000600310000616373704d5346540000000049454320735247420000000000000000000000000000f6d6000100000000d32d48502020000000000000
00000000000000000000000000000000000000000000000000000000000000000000000000000000001163707274000001500000003364657363000001840000
006c77747074000001f000000014626b707400000204000000147258595a00000218000000146758595a0000022c000000146258595a0000024000000014646d
6e640000025400000070646d6464000002c400000088767565640000034c0000008676696577000003d4000000246c756d69000003f8000000146d6561730000
040c0000002474656368000004300000000c725452430000043c0000080c675452430000043c0000080c625452430000043c0000080c7465787400000000436f
70797269676874202863292031393938204865776c6574742d5061636b61726420436f6d70616e79000064657363000000000000001273524742204945433631
3936362d322e31000000000000000000000012735247422049454336313936362d322e3100000000000000000000000000000000000000000000000000000000
0000000000000000000000000000000000000000000058595a20000000000000f35100010000000116cc58595a20000000000000000000000000000000005859
5a200000000000006fa2000038f50000039058595a2000000000000062990000b785000018da58595a2000000000000024a000000f840000b6cf646573630000
00000000001649454320687474703a2f2f7777772e6965632e636800000000000000000000001649454320687474703a2f2f7777772e6965632e636800000000
00000000000000000000000000000000000000000000000000000000000000000000000000000000000064657363000000000000002e4945432036313936362d
322e312044656661756c742052474220636f6c6f7572207370616365202d207352474200000000000000000000002e4945432036313936362d322e3120446566
61756c742052474220636f6c6f7572207370616365202d20735247420000000000000000000000000000000000000000000064657363000000000000002c5265
666572656e63652056696577696e6720436f6e646974696f6e20696e2049454336313936362d322e3100000000000000000000002c5265666572656e63652056
696577696e6720436f6e646974696f6e20696e2049454336313936362d322e310000000000000000000000000000000000000000000000000000766965770000
00000013a4fe00145f2e0010cf140003edcc0004130b00035c9e0000000158595a2000000000004c09560050000000571fe76d65617300000000000000010000
00000000000000000000000000000000028f0000000273696720000000004352542063757276000000000000040000000005000a000f00140019001e00230028
002d00320037003b00400045004a004f00540059005e00630068006d00720077007c00810086008b00900095009a009f00a400a900ae00b200b700bc00c100c6
00cb00d000d500db00e000e500eb00f000f600fb01010107010d01130119011f0125012b01320138013e0145014c0152015901600167016e0175017c0183018b
0192019a01a101a901b101b901c101c901d101d901e101e901f201fa0203020c0214021d0226022f02380241024b0254025d02670271027a0284028e029802a2
02ac02b602c102cb02d502e002eb02f50300030b03160321032d03380343034f035a03660372037e038a039603a203ae03ba03c703d303e003ec03f904060413
0420042d043b0448045504630471047e048c049a04a804b604c404d304e104f004fe050d051c052b053a05490558056705770586059605a605b505c505d505e5
05f6060606160627063706480659066a067b068c069d06af06c006d106e306f507070719072b073d074f076107740786079907ac07bf07d207e507f8080b081f
08320846085a086e0882089608aa08be08d208e708fb09100925093a094f09640979098f09a409ba09cf09e509fb0a110a270a3d0a540a6a0a810a980aae0ac5
0adc0af30b0b0b220b390b510b690b800b980bb00bc80be10bf90c120c2a0c430c5c0c750c8e0ca70cc00cd90cf30d0d0d260d400d5a0d740d8e0da90dc30dde
0df80e130e2e0e490e640e7f0e9b0eb60ed20eee0f090f250f410f5e0f7a0f960fb30fcf0fec1009102610431061107e109b10b910d710f511131131114f116d
118c11aa11c911e81207122612451264128412a312c312e31303132313431363138313a413c513e5140614271449146a148b14ad14ce14f01512153415561578
159b15bd15e0160316261649166c168f16b216d616fa171d17411765178917ae17d217f7181b18401865188a18af18d518fa19201945196b199119b719dd1a04
1a2a1a511a771a9e1ac51aec1b141b3b1b631b8a1bb21bda1c021c2a1c521c7b1ca31ccc1cf51d1e1d471d701d991dc31dec1e161e401e6a1e941ebe1ee91f13
1f3e1f691f941fbf1fea20152041206c209820c420f0211c2148217521a121ce21fb22272255228222af22dd230a23382366239423c223f0241f244d247c24ab
24da250925382568259725c725f726272657268726b726e827182749277a27ab27dc280d283f287128a228d429062938296b299d29d02a022a352a682a9b2acf
2b022b362b692b9d2bd12c052c392c6e2ca22cd72d0c2d412d762dab2de12e162e4c2e822eb72eee2f242f5a2f912fc72ffe3035306c30a430db3112314a3182
31ba31f2322a3263329b32d4330d3346337f33b833f1342b3465349e34d83513354d358735c235fd3637367236ae36e937243760379c37d738143850388c38c8
39053942397f39bc39f93a363a743ab23aef3b2d3b6b3baa3be83c273c653ca43ce33d223d613da13de03e203e603ea03ee03f213f613fa23fe24023406440a6
40e74129416a41ac41ee4230427242b542f7433a437d43c044034447448a44ce45124555459a45de4622466746ab46f04735477b47c04805484b489148d7491d
496349a949f04a374a7d4ac44b0c4b534b9a4be24c2a4c724cba4d024d4a4d934ddc4e254e6e4eb74f004f494f934fdd5027507150bb51065150519b51e65231
527c52c75313535f53aa53f65442548f54db5528557555c2560f565c56a956f75744579257e0582f587d58cb591a596959b85a075a565aa65af55b455b955be5
5c355c865cd65d275d785dc95e1a5e6c5ebd5f0f5f615fb36005605760aa60fc614f61a261f56249629c62f06343639763eb6440649464e9653d659265e7663d
669266e8673d679367e9683f689668ec6943699a69f16a486a9f6af76b4f6ba76bff6c576caf6d086d606db96e126e6b6ec46f1e6f786fd1702b708670e0713a
719571f0724b72a67301735d73b87414747074cc7528758575e1763e769b76f8775677b37811786e78cc792a798979e77a467aa57b047b637bc27c217c817ce1
7d417da17e017e627ec27f237f847fe5804780a8810a816b81cd8230829282f4835783ba841d848084e3854785ab860e867286d7873b879f8804886988ce8933
899989fe8a648aca8b308b968bfc8c638cca8d318d988dff8e668ece8f368f9e9006906e90d6913f91a89211927a92e3934d93b69420948a94f4955f95c99634
969f970a977597e0984c98b89924999099fc9a689ad59b429baf9c1c9c899cf79d649dd29e409eae9f1d9f8b9ffaa069a0d8a147a1b6a226a296a306a376a3e6
a456a4c7a538a5a9a61aa68ba6fda76ea7e0a852a8c4a937a9a9aa1caa8fab02ab75abe9ac5cacd0ad44adb8ae2daea1af16af8bb000b075b0eab160b1d6b24b
b2c2b338b3aeb425b49cb513b58ab601b679b6f0b768b7e0b859b8d1b94ab9c2ba3bbab5bb2ebba7bc21bc9bbd15bd8fbe0abe84beffbf7abff5c070c0ecc167
c1e3c25fc2dbc358c3d4c451c4cec54bc5c8c646c6c3c741c7bfc83dc8bcc93ac9b9ca38cab7cb36cbb6cc35ccb5cd35cdb5ce36ceb6cf37cfb8d039d0bad13c
d1bed23fd2c1d344d3c6d449d4cbd54ed5d1d655d6d8d75cd7e0d864d8e8d96cd9f1da76dafbdb80dc05dc8add10dd96de1cdea2df29dfafe036e0bde144e1cc
e253e2dbe363e3ebe473e4fce584e60de696e71fe7a9e832e8bce946e9d0ea5beae5eb70ebfbec86ed11ed9cee28eeb4ef40efccf058f0e5f172f1fff28cf319
f3a7f434f4c2f550f5def66df6fbf78af819f8a8f938f9c7fa57fae7fb77fc07fc98fd29fdbafe4bfedcff6dffffffdb00430005040404040305040404060505
06080d0808070708100b0c090d131014131210121214171d1914161c1612121a231a1c1e1f212121141924272420261d202120ffdb0043010506060807080f08
080f201512152020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020ffc2001108008500
c803011100021101031101ffc4001c0000010501010100000000000000000000020001030405060708ffc4001a01000301010101000000000000000000000102
0300040506ffda000c03010002100310000001cef90fb09a72952d6a75cbea4d4e63c8fb5e46b47b7ac13eefbbc600d1ab0076056ce0100416acafcf72f764c5
b2c88cb7775e3dda7264f5754ed3360db03601aa1102d6c81bcfca398411c56ce32d9d4101c847bb834e8bbcea88916beadd3e3db6907534b4989384bd3c6b57
b1dcfd09846af1ab3660044e582d96ce0b8c977982f6f3d37b5257036b9fabd4fd0f0a4558fa5e5acf3a5d3e2d4eecbbc3604bdbb9a4db0e6118183157c160f8
ac5d5a347f15a74410725d6263afe6eaf48eef09d7074996aa0a7cea3eb705d52c4e9e4f68e0af54a83b33289472ae558e432c5c3514af8776343ced624d7f9f
a3d1a27b2b798614fb94983918fcddbe1fd74c0e9e4d74deede75e4647644513222110b640a0d842bc5deb940e0149f97b7dab8d374f1985b3e945d821a0957c
a376f95fa3c359e5ed1e7f5773006e8e5132b156216c81607917b60d2a294e7185b8dbd53cdbc926255e8bdaf1d6c2a6347c89f57cf3ea72e3db9b690fbf799d
368cdd95ca265121608e056f34e8b516a62837675ea796fa5e67a4b9fa6ca6f41fa7f91e7bccf5f3d9f03ba16d27c2d5312d0b197b291d645264e9d652ba065a
6af66b2a894f30e8e9c12dae94b894e8b92d67cef4adcab6267b3f67e7208d2bad7396f84dabbcb61277424f49d5a2d869a74074899200d18311192691ea47a9
5453a1e6b75ca97edcd61e3ccf93ee36c8e00d09d1b4e85a117571eaa248c8656ab2e55467d044da33a326916bd36d293cf3aef21e9001471538fc3e857d5061
015379d829436c2eff003e769c84390442da26d20d608ead92cbeb20a9b20c4ac919908ccf21e7fbce529d6557a79bb6bf0d20451dcace54ca995321c81d9308
b1a28d9aadaef3d1759f31024aee19d779d799ee994ad49e7d274a9372b6996f64be8b7535802719f013a225866d9d73111632309e82d93054684df84e1f55ca
46c80c88a8b2d8cb315972332915b886da9914b6cfb2c61c63c50cc0be311780b366c74acd95ca8b21e05945d642b3653c0b006d19138d710ce8c810c6224766
0483163097af9b9971a73d2e08a8b2cb84a01b239078160632d85b44c076b2bae4d9958098f173833572f51cff00ffc400271000020202020005050101000000
0000000102000304110512101314152120222330310632ffda0008010100010502af2d5695cb5d26526ce5d7af51597af22a09996abbf1aea178c707337fa6eb
7a0b73ea42f9f6bc2db338bab55388bc6e341c7e34f6fc79edb8f3dab167b56346e130ccf65c5598bc7d78d67e9e62deb429d9dcdcabee7c44eb5b41e0cea82f
e5f168193fe8ec2389cff5b87fb39bbbf3d66769b982bdb2291aa8c1e19950bb1eea4d76389c2e6fa4cf0db1fa9ce9390b7cce401d0ed17e4f169b71f00c1e0c
36398c6eb1c7c3ec1e173c65e16e6ff4e5375aafa6c1779b15a24e213f10fa732916d194a68b9da70f9de93391c3afe9cf7d56ca1a5b88ad2ca1e995640338f4
e947d2dfcff418718cdce073fd462fe9cfb3ee8cc00bed16b5184ad70b854bea84f553b09dd67710b4cda45d466d268c99c6659c4cda6e4b2bee27713b4dcd89
b13719beccdb8b65f9c105b9165cd8f474984377dcdf954f835408b0148d7f90afcbdd64a33b2ae4e4b1fb5c38d768386b8cc3c6cfc756f702455c896ae96ea4
6a7c18287f36c53d2c3d71f27cc46d59735552a0dce3ff00e06364315c6b84f4f6c366e7c464ada3a56b2fed282cb120eb0d9d51722d8320c39680faca8c3954
439b54f5f5cb6faecacd8b3ad6d0e35261c1130686088ee816c46f0dcdc0e561b0c2e67dd2f6b02d64ec749f6cd88f5abcb53cbf1dee323b0eb9ca557334b4e4
7508c138dfe7c19d04d389b84fcf710dc04acb5a3a58a2d606b1c960ac1cb7193de38b9ef5c64f7bc09ef58f0729483ef16caf90e46d38eb94cb563574c2cb37
3e3c35353460b277967f31f1bcf643522e552f90130eae9e8717630f1c4f4f8f3c8a27934cf2699e5d027998c91b35046cdc833d466f9899d5c5bd1e6c78ee6e
6ccdec16962069d6043111a00c225b6082f58b6033737a9e609e66e7e49f93c3e2796860362c195608996a63d8e5aab3ecdf81f99a86a0604eb06a09a9d60dac
5bf5058ad3e3c373b426769b9b3e0c81a75759e75cb036fe9fecd6a0fa089f316c6116f9d819a9a3e3b80cdc30995b180fd0209a83e8d4226a76222d8606dc33
535e061319a7ffc40029110002020103030402020300000000000000010211031012131420210430314122324051425271ffda0008010301013f01e75b459059
50b244e58d8e71334d367a56a8f54ed32bd9c58b77c8b11b628b123d5cabc1063f5733abc875990eb6675923ac97f473a7f4473a5f44b2a6bdac3e116596633d
4cae4458f48c1cbe05e95ff90a38e3f08cb15fb445dd6597d88b2cb3e206577310f4f4f3db224a8911ff0051c6bb6cb2cb2cb225963647cb32ba88c43d22c8cb
7c2c648fdd595d97a5e965912d9bcdc6247a97f88fb704e9d13f0c9331ce9d0c631f7c74a2a8c534677e6bba24ff002858c6467ba23efbd13132cbbf04511c5c
96ce94e94dacd8cd8c51313fa322a6331ca98fbdca84c4597645511661f102f48e46998da912499e2bc11b26ace338f56cdcc7214af4cdfa98dfe3aa1310b241
7d9cd0fece7c7fd8b1d1ff0004e421c91bc721b1f91c46b47a58dd884c421116bec9414be096392d28a1c14858d0e28a4645e0b1fb5626290d9e4de5c5fc95ae
e1e48af937c5fd925e28716b4a36336338d9c6718e2977d965a290c64e7b476fe48cf69d448ea247348e591c9239246f917236c99c7238cd838b2bb28a1bd18f
4a286b4dc5eb456946d28a36238cd86c66dd1fbf5a5695a228da5e8fddb2fd9bfe4fffc400271100020201030305010101010000000000000102110312132110
3031042022415132714061ffda0008010201013f019fa66e64bd3325e9e42f4f33624912c523d2637147ac5f230aa5da9cabc0db63b12ae9815cac92349b66d2
364d9364a92fb256fc9cf6a4ad92545144f846055024210e5a4d6df81636fcb3f87a5f7631268d2513e59055148911e993f48cac4ccb1b565f6a86254868d232
ae5d18844910e1d084648e8976e86b8a1e2fc1c4998d7cafa3285d26ab921cab1232c3547b715cf4b387e4c985a22bd9432460953a174cd0d2fb504328aa272e
192969e0dc1e435a3711ad0e478766376ba648ea4557bd2b1aa20b828aa2465f06456c6868960543e04acc78235726648417831c8dc46ea2528485a0f81a50a0
38d74c5fd13fe855d19465f234c7063848795b3fd383511ff492ff00d28a170596722b39341b6cd2fecd2726a66b3273e08b6852470596597d71792bd898bd96
7c075fa3a18d53e95eca349a19a24478628d9b4cdb34234c4f81aa3fa5c054fc15d1f5a1a348e2fa210a3621ad46cc4d98fe9b31fd3661fa6d43f4d981b58cdb
c68bc68de88f39ba9fd8a66b2d76132cd46a2c691a0aaeb451c0ebaea685919b86b1648fd8e4bebda99e7ad96793495dab351657bafdb7d290e3daa1aff81c7b
147fffc40037100001020304080305090100000000000001000203112110223132041213203041517105618123339192a134404450627282b1d1e1ffda000801
0100063f02ca665652b036628de46ab1512478545576b1574ea8b5bf3599164591645902c817bb0aeb648b982a78520713bbf4dc9b96799f24760c97741e7373
e2b61f4aee3021e75dc737a84e6bacd471f671388544f2a6e39dd0296eed00b263109b337db43c329d10733357a96877533de2d4e866c13371f42811c222d98c
100534746efed982d0c71bcda70836caad935426cb9a975aee636b9a5399635d3ba6850703c09a701c954ad56299c56b72689a23a53708aa2f72f6508a94766a
29b44d652a8d280ab82a43430015ec6dd6d6a5ae76ccd55682d73bcd4f665642b2158aaaab66a90fe8a90dc7b291d0dcab064b0540aac0b2a92aacca86c9b5f5
1c955640561257627c56a8a96a93db3dcc563662b321227d148cfe3b955564c750ba85fed0aeaa8d3eaae43791d94e2682f1e6da2d6911e4f0b5ccbd13a2c8c8
d2da1b3c9557557184a996482241527c6d4eed2bed7f0615efe21ed08afc43bb4357745d31dfc153c374b3e8a70fc0e2cfd02bbe06ff009d4a1781fab9ca7a4b
2143fd2caabbae7f7bcbbfb5592af00a9c58a18cef5283585a02019a4ecc04369126eea1722b92e4b95b8aff008aec37395c820775388dd76f4064af35d0fb85
4703c19852598ac4aa2a99aad15372eae4ab6cc2bb10faabc26ab4536b95ec787457adc38375df70afe49fffc400281000030001030304020301010000000000
00011121314161105171208191a1b1c1d1e1f030f1ffda0008010100013f21350b67f11946af629e589cb0d081f4acc914840cd036363f53549a37b9ed0742d9
e0c759bac6d3c1a175adf8e8a2b47c1d90e30dbb3e0ffc01cc35bf88fd043766e9b0d8dfaf4e0e06f8285d2b3f22302d122bd28bb22e479a8adb2119c3656eca
70bd98d8fa31b2fa9b8a97ab4518af4e93ca159ccfd06f18572c323472e5c2f86216d32946c6fd7745a275309a2a63078105ee6226d8e84ea1f6b086e6658ca9
fa0084bd6fa6af819836dcc29c2d09794e8f83225facb4fb18a242e8f52b830431e0cc3178301a55a8bff1e56c15aa16bc19a7034b0cb2acaaf96265213a2d0c
4b69af49b2756a8eee784c5e9a5296a3928c2da0b29b753b2468b979c9f8fd0bbc4f725af495d188b04d56a1ca58b81b35f041265a68e53948ee41cc5b71a255
884c1806301d12d87f717baee3235941b99fd0584f032aa3a450d6178d847715eb0813685b98bf73f8cc6a19914d9b197535dd94eee4516a84eb44b0ab7b12ec
79379c8af2dab52376f68d207112435bd1de64a455e4d60909b20f818a310d01f608f7c2217bc93486bf9670508741b16bf186f59291865d19195028b2b1e9ba
c861b0740b3ca1bf94bb9a7b78b1cdae105ac41b6d77625c15ba34a8636868a3a411455e4677e84dbe45802a1acd72317f627da8e1468ecf71e97eaef23cab16
a269e4b5ca9cdb007a0978359f935135b27ec5e169921e40370a497217ba29065ca94d6b50e74dec7414cd062fd435ea9e4d29a0ccd42d7036af2356ccbe25c0
e32cb6fd0423aff8f8124c27a7bc099f426bf7326a2a5b90abadbeed3f826c2e025f26507ee37c96db35eff900ac4d5b1c1d092d887aa38b185387ba1a771ee6
a9fd1859181558e893171b3a256b125772824cad36ce61a1af8a33dd5ec7f9412fb7d1e1f92aad7e4e27b5185f14a1f7d21e4c1e95271feb22ef8f627956cc57
b929ca409cb0f28bd4c8f587d0471911453f229334e480d8c6c1c9c80d4744e2860778d0f413e469968124da57b8db6a36211f7583631db23169f03b81c8c98a
3268522b794f27784bb191289b1da44190c5f5cd121a73237664482920cfa0d2e8347a1c827dce00dc23d6e4904c793429204fa3a15137b928d223c1cb8878c3
a375a31a87ca141f507eb2b746ba309485d48592040c2d0be9d88431a8c21878e48fffda000c030100020003000000106b0631a8f6e44e0c76cfc6a197c34b9c
d5a5e0fb54038412dabf4d200da8ebcf66ea2642070e2ecb9e6ef3daaf46c64184b704900e32fd4ed133cd5d6d80b812412cbe809ae198e77100949233ff002e
20ddb23398c9b0917cb5da4fe182bd6b94f1d5ab100351287c7902e5b68139144dd8dc3e3dfbc7e8199d0098cd819fcd9cdd48ab2249280e782fc18ff9527a96
29a4292210f465cc52715aba0ea39c6ebfffc400271101010100020202010304030000000000010011213110415161207191f03081b1d1c1e1f1ffda00080103
01013f104389cc21c966bb8b6ddacdbb30e6e1760317682083f226bd220c3823aa4ead38b03fa0ff009f083a09fabc1fa37d65a708bdc374189867bb39820fcb
21cfe2c672e5900fd5f13966f2139790bd8fdce02e184441e37f003e0359e01702e4ce9c8e66d0fae3c5cd93bee548c266afa7fcda31820ba967f002116b1cae
5c401e28190d75f05360df682ce5bdd2504f71e0b2ccdf0d8847cc03a472e6757b9b1c1fa7efff0050b2596db9974cd62e4b9b74dc65294b2db6c30ca1b2cbe4
4c0b7112c96d89e3708f64e79653ee52cb2cb6db107cc11db166992afecff3f7956a1babebb1ec9336f6adf2571cf4ca665996d806b6c693e2316f81e27b2e27
df3fbc4610c28c4625c382f62678cfce4c08632d91c7814eed516ba5b08788d679e0e667cc46407d2c3d6ec246905c6cb4d5847521f5690c0507cc07b9c81663
a10cb0624b3af0294a224575e37773bee79e463d486a41f57c39f8eed92b64cb2db6cbe46123ede5053211d42e98e82dac664b938bb865bb0e522a771236dfe3
fead3ff1ff0057f2e7c1ab5768ce7af1b16c30afb453e47ac1acd36777399d38253d4bfa95f536c296deaf84c27647cdb21c42ecf036186356bc0bb2b94e4891
ebc0697dac3259b6885e00f86acbddadf56d90109ee594b2ccccc925996dbe0b3c02d41f3620b84060782ca6d999667c659e062134f231110c2b65999966dfe8
0c30dbe06186dbffc4002511010101000203000104020300000000000100111031214151a120618191b1d1c1e1f1ffda0008010201013f10eede090f86cde188
f522993dcc8e692bb9c16df12cf19659270fe33c87715e178409e6daf81ff5c06bb6036d03d36becfb6c7460fbac5870f1965924927058274c709b8fdff88c61
1f6ba664e8d58599e72cb2c9249b4f3fa20e05fd99fdff00d42110cf08009c5e3fd91b2db780b2cb2c9261f1c26cce08e118897cf01c3727e45e2d9cf32a1e9b
620820b2cb2c9274842e92463c30bf86e144125a31eac10e2ebbb20fb11041671964969772ed7a45b89642fde18390e9790f00bce9d30701071965925dec2d3d
465aca26c40fe5261b2e15a0dc9f00b098237252c6218638c25584cb1b133bb116c3a7db6794dff3e61acb6789312be7b00796cbdd9f6f1c09e586e9d41eac5b
3d65e1e5115347867833a3f69cee5f0caf575accfd96badbcbb82d59d3b0e6c1c3f90fa12f9914a60dd1bc935ead1eecedfb26b5f6bc026df0c2b82a19698585
90e5919a5911213de98888076cabb603a8b599fd5e4e136193931d3abc7026143f46c91a93c197af01f6ff008ff71ee7f25876fe4b07b3fbbc38fe565ece5384
895f778982cfc5ea58c2f58bcac1e0bacf51f68fb22d8c3ff75fbbf982f7f9b56afe63af927d30fa9ec43f4dfbad271e999725d8b320d9cee17636a7ee0bdcff
0036bd4bedc6c6a71df05e9c9d46f623ea2e4c16c84478eb852d8ec6c42a9da7e251df1bfa326ce0642f76271645bc1e235c78b3e43f6268cb4a489c6fe878ce
05267031c8f1bceb0c360c1271b6f19044ffc400261001000202010305000203000000000000010011213141516171108191a1b1c1e1d1f0f1ffda0008010100
013f106a73081d65206d754f9e528f6a31aa8a2417d25049ef0c54150cf760d9b8d3da69f12ff497a1083061b1dc4ea2a1babdc7d60e1e5f78b969955bb8c17c
acb2b91f134fd21e710016fb200a3e385383f69b3f8517b53f647b0a1e84b0b8b059901a9b0b2e817ea0bea420f58a4c3823486dfc8f7b6b65611c16e282ad41
19940776a3fb25a306218e8a7955411a7ba1a06ca6d7f04d18d4e0852ac688bd07d443d2e7a08075ac0f2d1f8ca2cd46d45cb20eb0ea2cf8c67f89627917bebe
aa0b187042585d2186a5dc2c05e652c28971c152e3858611136465f4192199999832e0c2b9ac4c7a49ceabfbb950b8fb6287494617479963f2574800f68ac954
09783a605f03907112399429a85b12565a615e6ce630c36f41a95a8b2e5c194a3a6fd414000f55b9bb0b1981613acc65db29de86f67f83efd16c4a48220950f5
a554099b5972455371298c1781e18004036730bc1bf55972e5cb9443a7de56098841cc5d79911e91f4e6acc5aa03f90fe7a54a8461182d89b65ce86c88ac30c8
962710ac42a5729c3e8692e2e22cbf51a0b0ccd9542cadc0c4036cca42a44a7c4bcd6c1b7eae5460cf6b81f16f79c28c18870d546bd23acdccb13307c59ab942
42df18cb2f1820de29e6186122303dc09c65bc23d6947183282b2f451084e2a5f8a9f76e2b35d6ae38b4d5e04afce655b61ae513f0fd967e5575d453f631516f
a06e2ba8e405e298e834be60758d11b85310e3710b2a106d48a8b5ce5091017820850bd584af37a038250c9e59596f726ea68f8ce66dd656058a7497b36d406e
1a45a95728226bd721cc1c415d8a5825059302b022e3761d0387bc52e2594ab58b51531a9530f78d4a08232c15fb91101744b218b788540f7a181e68f50f961b
bf662621fad162bb827544c5ae521f1a1a5ea092d4a4ea471431d259e9f80cc415172d6a16e501a5973f3a992b7804b4546570a2e2cfd90ce1e4e2c4bf8b9a97
8aadf785dd6bb12985f45e21535f2c3c08f0c7758f94e2bf12ed50ee131c55d897e308bb1fd4b6fcf65528176bde07af9a5e501ed0ce068e122ceed9f83679d4
6b0484094ecde6215300ad41d7fac4c933b6781b8a42f217e046258aacdbe496e20bb1b672d388e62054001cda95de51511558e3748665ca8cf4581969ced4f6
96590f78a6d5792e3fc119468afa89b9d8b648bb674da00d95e0b8ab869188f4bd40fdf68003e61d3460a2b59a8ad18ca6fd930ccbdc7e88a63c95fccb74bc0b
f6156475c2cd48991b175b90edbadb71e0081581c15742794109341b05e5d07b0cbe97b5ff00b595ed53722e09798bc63f0090b180f6250d08e82cb0643ce670
d18cb7c29cc23b12b657de39758e344c8103a071e61775a1ff00d599a4401dd36e4ed070095f113350f1275bf92a9156bfe728b1ef7fc41f47b7fa4ca01ef7fe
100cfe12ff006da75f88970b4ea2fc852a4e88fb86a7466d622be521be5ab98523ac7f0b21648ed4e52a591cd2d805f9964ca8e0b83e503d79966f50dc0bd26f
a83d1a96885ec6f8978b8b16912248d6b1122abc434dfd095a498e8c54ee864a3bd457b116f09ed2fb21c54ab168350ff12b27cebea53d81051043975300bb51
999345092c84f28330c75876435eb8260bc01e605c2e183044b8a60458c572e63c13da353dc403097c4a76107883c1021a22e6611790992753c896e44cf5aba9
1fa216094904236f31846e62ba865704e489c910b51299c4af5348458c449885f246505b4251fc881b090738778210c41070d44bc45e6386483d677263151c16
41ed0eb10c36466a0ed1259166a013094d88a6c83e210c4b2c6e12e67040992585826462a3ac5a84b89527ffd9}}}}}

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225\rtlch \ltrch\loch

\par \pard\plain \s51\sl288\slmult1\ql\nowidctlpar\hyphpar0\sb0\sa140\ltrpar\cf17\dbch\af9\langfe2052\dbch\af13\afs24\alang1081\loch\f3\fs24\lang1033\qj\widctlpar\sb0\sa225{\scaps0\caps0\cf1\expnd0\expndtw0\i0\b0\dbch\af12\rtlch \ltrch\loch\fs21\loch\f8\hich\af8
Nunc ac faucibus odio. Vestibulum neque massa, scelerisque sit amet ligula eu, congue molestie mi. Praesent ut varius sem. Nullam at porttitor arcu, nec lacinia nisi. Ut ac dolor vitae odio interdum condimentum. Vivamus dapibus sodales ex, vitae malesuada ipsum cursus convallis. Maecenas sed egestas nulla, ac condimentum orci. Mauris diam felis, vulputate ac suscipit et, iaculis non est. Curabitur semper arcu ac ligula semper, nec luctus nisl blandit. Integer lacinia ante ac libero lobortis imperdiet. Nullam mollis convallis ipsum, ac accumsan nunc vehicula vitae. }
\par }
    ";

        #endregion
#region Fields

private string _text;

        #endregion Fields

        #region Properties

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        #endregion Properties

        #region Constructor

        public TextElement(string name) : base(name)
        {
            Width = 100;
            Height = 100;
            Text = DefaultText;
            Background = Colors.White;
        }

        #endregion Constructor
    }
}