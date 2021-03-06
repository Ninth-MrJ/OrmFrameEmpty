﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OracleDataToRedis.Coders
{
   public class ResourceFileCoder
    {
        public static void Write(string filePath)
        {
            FileStream file = new FileStream(filePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(file, Encoding.UTF8);

            sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sw.WriteLine("<root>");
            sw.WriteLine("  <!-- ");
            sw.WriteLine("    Microsoft ResX Schema ");
            sw.WriteLine("    ");
            sw.WriteLine("    Version 2.0");
            sw.WriteLine("    ");
            sw.WriteLine("    The primary goals of this format is to allow a simple XML format ");
            sw.WriteLine("    that is mostly human readable. The generation and parsing of the ");
            sw.WriteLine("    various data types are done through the TypeConverter classes ");
            sw.WriteLine("    associated with the data types.");
            sw.WriteLine("    ");
            sw.WriteLine("    Example:");
            sw.WriteLine("    ");
            sw.WriteLine("    ... ado.net/XML headers & schema ...");
            sw.WriteLine("    <resheader name=\"resmimetype\">text/microsoft-resx</resheader>");
            sw.WriteLine("    <resheader name=\"version\">2.0</resheader>");
            sw.WriteLine("    <resheader name=\"reader\">System.Resources.ResXResourceReader, System.Windows.Forms, ...</resheader>");
            sw.WriteLine("    <resheader name=\"writer\">System.Resources.ResXResourceWriter, System.Windows.Forms, ...</resheader>");
            sw.WriteLine("    <data name=\"Name1\"><value>this is my long string</value><comment>this is a comment</comment></data>");
            sw.WriteLine("    <data name=\"Color1\" type=\"System.Drawing.Color, System.Drawing\">Blue</data>");
            sw.WriteLine("    <data name=\"Bitmap1\" mimetype=\"application/x-microsoft.net.object.binary.base64\">");
            sw.WriteLine("        <value>[base64 mime encoded serialized .NET Framework object]</value>");
            sw.WriteLine("    </data>");
            sw.WriteLine("    <data name=\"Icon1\" type=\"System.Drawing.Icon, System.Drawing\" mimetype=\"application/x-microsoft.net.object.bytearray.base64\">");
            sw.WriteLine("        <value>[base64 mime encoded string representing a byte array form of the .NET Framework object]</value>");
            sw.WriteLine("        <comment>This is a comment</comment>");
            sw.WriteLine("    </data>");
            sw.WriteLine("                ");
            sw.WriteLine("    There are any number of \"resheader\" rows that contain simple ");
            sw.WriteLine("    name/value pairs.");
            sw.WriteLine("    ");
            sw.WriteLine("    Each data row contains a name, and value. The row also contains a ");
            sw.WriteLine("    type or mimetype. Type corresponds to a .NET class that support ");
            sw.WriteLine("    text/value conversion through the TypeConverter architecture. ");
            sw.WriteLine("    Classes that don't support this are serialized and stored with the ");
            sw.WriteLine("    mimetype set.");
            sw.WriteLine("    ");
            sw.WriteLine("    The mimetype is used for serialized objects, and tells the ");
            sw.WriteLine("    ResXResourceReader how to depersist the object. This is currently not ");
            sw.WriteLine("    extensible. For a given mimetype the value must be set accordingly:");
            sw.WriteLine("    ");
            sw.WriteLine("    Note - application/x-microsoft.net.object.binary.base64 is the format ");
            sw.WriteLine("    that the ResXResourceWriter will generate, however the reader can ");
            sw.WriteLine("    read any of the formats Listed below.");
            sw.WriteLine("    ");
            sw.WriteLine("    mimetype: application/x-microsoft.net.object.binary.base64");
            sw.WriteLine("    value   : The object must be serialized with ");
            sw.WriteLine("            : System.Runtime.Serialization.Formatters.Binary.BinaryFormatter");
            sw.WriteLine("            : and then encoded with base64 encoding.");
            sw.WriteLine("    ");
            sw.WriteLine("    mimetype: application/x-microsoft.net.object.soap.base64");
            sw.WriteLine("    value   : The object must be serialized with ");
            sw.WriteLine("            : System.Runtime.Serialization.Formatters.Soap.SoapFormatter");
            sw.WriteLine("            : and then encoded with base64 encoding.");
            sw.WriteLine("");
            sw.WriteLine("    mimetype: application/x-microsoft.net.object.bytearray.base64");
            sw.WriteLine("    value   : The object must be serialized into a byte array ");
            sw.WriteLine("            : using a System.ComponentModel.TypeConverter");
            sw.WriteLine("            : and then encoded with base64 encoding.");
            sw.WriteLine("    -->");
            sw.WriteLine("  <xsd:schema id=\"root\" xmlns=\"\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:msdata=\"urn:schemas-microsoft-com:xml-msdata\">");
            sw.WriteLine("    <xsd:import namespace=\"http://www.w3.org/XML/1998/namespace\" />");
            sw.WriteLine("    <xsd:element name=\"root\" msdata:IsDataSet=\"true\">");
            sw.WriteLine("      <xsd:complexType>");
            sw.WriteLine("        <xsd:choice maxOccurs=\"unbounded\">");
            sw.WriteLine("          <xsd:element name=\"metadata\">");
            sw.WriteLine("            <xsd:complexType>");
            sw.WriteLine("              <xsd:sequence>");
            sw.WriteLine("                <xsd:element name=\"value\" type=\"xsd:string\" minOccurs=\"0\" />");
            sw.WriteLine("              </xsd:sequence>");
            sw.WriteLine("              <xsd:attribute name=\"name\" use=\"required\" type=\"xsd:string\" />");
            sw.WriteLine("              <xsd:attribute name=\"type\" type=\"xsd:string\" />");
            sw.WriteLine("              <xsd:attribute name=\"mimetype\" type=\"xsd:string\" />");
            sw.WriteLine("              <xsd:attribute ref=\"xml:space\" />");
            sw.WriteLine("            </xsd:complexType>");
            sw.WriteLine("          </xsd:element>");
            sw.WriteLine("          <xsd:element name=\"assembly\">");
            sw.WriteLine("            <xsd:complexType>");
            sw.WriteLine("              <xsd:attribute name=\"alias\" type=\"xsd:string\" />");
            sw.WriteLine("              <xsd:attribute name=\"name\" type=\"xsd:string\" />");
            sw.WriteLine("            </xsd:complexType>");
            sw.WriteLine("          </xsd:element>");
            sw.WriteLine("          <xsd:element name=\"data\">");
            sw.WriteLine("            <xsd:complexType>");
            sw.WriteLine("              <xsd:sequence>");
            sw.WriteLine("                <xsd:element name=\"value\" type=\"xsd:string\" minOccurs=\"0\" msdata:Ordinal=\"1\" />");
            sw.WriteLine("                <xsd:element name=\"comment\" type=\"xsd:string\" minOccurs=\"0\" msdata:Ordinal=\"2\" />");
            sw.WriteLine("              </xsd:sequence>");
            sw.WriteLine("              <xsd:attribute name=\"name\" type=\"xsd:string\" use=\"required\" msdata:Ordinal=\"1\" />");
            sw.WriteLine("              <xsd:attribute name=\"type\" type=\"xsd:string\" msdata:Ordinal=\"3\" />");
            sw.WriteLine("              <xsd:attribute name=\"mimetype\" type=\"xsd:string\" msdata:Ordinal=\"4\" />");
            sw.WriteLine("              <xsd:attribute ref=\"xml:space\" />");
            sw.WriteLine("            </xsd:complexType>");
            sw.WriteLine("          </xsd:element>");
            sw.WriteLine("          <xsd:element name=\"resheader\">");
            sw.WriteLine("            <xsd:complexType>");
            sw.WriteLine("              <xsd:sequence>");
            sw.WriteLine("                <xsd:element name=\"value\" type=\"xsd:string\" minOccurs=\"0\" msdata:Ordinal=\"1\" />");
            sw.WriteLine("              </xsd:sequence>");
            sw.WriteLine("              <xsd:attribute name=\"name\" type=\"xsd:string\" use=\"required\" />");
            sw.WriteLine("            </xsd:complexType>");
            sw.WriteLine("          </xsd:element>");
            sw.WriteLine("        </xsd:choice>");
            sw.WriteLine("      </xsd:complexType>");
            sw.WriteLine("    </xsd:element>");
            sw.WriteLine("  </xsd:schema>");
            sw.WriteLine("  <resheader name=\"resmimetype\">");
            sw.WriteLine("    <value>text/microsoft-resx</value>");
            sw.WriteLine("  </resheader>");
            sw.WriteLine("  <resheader name=\"version\">");
            sw.WriteLine("    <value>2.0</value>");
            sw.WriteLine("  </resheader>");
            sw.WriteLine("  <resheader name=\"reader\">");
            sw.WriteLine("    <value>System.Resources.ResXResourceReader, System.Windows.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>");
            sw.WriteLine("  </resheader>");
            sw.WriteLine("  <resheader name=\"writer\">");
            sw.WriteLine("    <value>System.Resources.ResXResourceWriter, System.Windows.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>");
            sw.WriteLine("  </resheader>");
            sw.WriteLine("  <assembly alias=\"System.Drawing\" name=\"System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a\" />");
            //sw.WriteLine("  <data name=\"bindingNavigatorAddNewItem.Image\" type=\"System.Drawing.Bitmap, System.Drawing\" mimetype=\"application/x-microsoft.net.object.bytearray.base64\">");
            //sw.WriteLine("    <value>");
            //sw.WriteLine("        iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8");
            //sw.WriteLine("        YQUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAAU1JREFUOE9jYBi0");
            //sw.WriteLine("        4O4C9v+35nH+vzqH6//FGbz/SXbodaDGP48a//952PD/5GQB0g04P50XbsDBHhHSDTg+SRBoe93/Pw+q");
            //sw.WriteLine("        /u9oFydswKWZPP/PTuX7fxKo8Ui/0P993SJAzeX//94r+r++Qeb/qhq5/0srFf/PL1X+P6tIFdPAU0B/");
            //sw.WriteLine("        /nlYD9RUC8SV///cKwHivP9/72b+/3sn+f/f23H//92MAOKQ/5NyNDENONQrDHbu3/ulQI0FQI3ZQI2p");
            //sw.WriteLine("        QI0J///digZqDPv/70bQ/3/X/f53peliGrCzXeL/lmap/+vAzpX/v6RC8f/fWzFAjeH/p+Zp/J+QpfW/");
            //sw.WriteLine("        O0P3f3uq/v/mREPCYTIb6E+Qc//dCPjfk6FDWAN6QgH5898NfyD2+9+arE+6Ad3pumD/gnB9nBHpBrQk");
            //sw.WriteLine("        GfxviDf8XxNr/L8y2oR0A0hO++RqAAAkI9ieo+gjUwAAAABJRU5ErkJggg==");
            //sw.WriteLine("    </value>");
            //sw.WriteLine("  </data>");
            //sw.WriteLine("  <data name=\"bindingNavigatorDeleteItem.Image\" type=\"System.Drawing.Bitmap, System.Drawing\" mimetype=\"application/x-microsoft.net.object.bytearray.base64\">");
            //sw.WriteLine("    <value>");
            //sw.WriteLine("        iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8");
            //sw.WriteLine("        YQUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAAW9JREFUOE+tkk0o");
            //sw.WriteLine("        w3EYx3dV3kq5uKBWDiPT8hISMiQsMiEyQ9qBg0hoFwcHUi7kgIvkQFJSTrQ4zdvmrTW1/kuT0i74x+X3");
            //sw.WriteLine("        MRal/fEnv8tz+H2fz/N8vz0azX88PG6wmcDp4E881hYR3VUIixF2Nr+FcO2DlbnPGjaWoM+M6DAiOitg");
            //sw.WriteLine("        YUoR8rqhsJTBWG/kP6fOMKTegGjKh/7mTyIx0oUw58C0/XubLM8iKtPeQIx2gfcMJgbD0FBVlRE+D7QU");
            //sw.WriteLine("        hS2ZshANuTDQqq75fQIHe6GVcxHV6VCr/2VzQIKmAshOQNbHc6+PhTqDOggBP5jzoDCJoLUaLo7fwr3V");
            //sw.WriteLine("        hSCr8z8EeHcLbSU8FCfjLU0nuL/70cB4Py5tDLL7UBnC8xMMW6EkhRNdIsGt9QjhTXkGUnsN8rVf4Q72");
            //sw.WriteLine("        tpFzEnGlRiH1NIL8qDjJoY1DdjkVADNjSGnReI2ZIF196VW22+D8SAFw6YLJITjaV5e2qotSIXoBiiMD");
            //sw.WriteLine("        HEVvQ/IAAAAASUVORK5CYII=");
            //sw.WriteLine("    </value>");
            //sw.WriteLine("  </data>");
            //sw.WriteLine("  <data name=\"bindingNavigatorEditItem.Image\" type=\"System.Drawing.Bitmap, System.Drawing\" mimetype=\"application/x-microsoft.net.object.bytearray.base64\">");
            //sw.WriteLine("    <value>");
            //sw.WriteLine("        iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8");
            //sw.WriteLine("        YQUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAAeJJREFUOE+lk9FP");
            //sw.WriteLine("        klEYxv1TSsecde0f0FpZrTbbal7URVvZuuJCr7pq2WzLNWy0iSHNwtIB9qG0ltLSYRJpBomUgZPMGSyU");
            //sw.WriteLine("        8SmJIOiv7zssCdrAzXd77s77e5/nnPdUVR20HBPfUCWNB4QsI176HB8IL/9iX2y1ubTMwx6utz0nuLhc");
            //sw.WriteLine("        GWIfCxT153Z26ep/g9Md4FJLZ2WIZdQnAM4QSJ/BH5Z5aH6NNCljm0hgdSV4MppAPxQXCq5kil31OTx7");
            //sw.WriteLine("        DjLbOeSNNJFYUgBKq31glfpmN76F9QLEZHOJc73ubXQjMreln7Q+DdP/du0/QIsxhmNK5mjTMJ/m43mI");
            //sw.WriteLine("        Qcmr5t5MZVlNpFiKrPM1vIbpVVQAOqSckF+ZekUX5UjTS+ouDFLb+CwPUPNupbN7k7WmEDcMX3hgXSpy");
            //sw.WriteLine("        IP/OsrCyhXtuA6M0g+bc4wJATqaZ/x7DF4zg8f9g/OMibb355701kERriHL5fojzd2aFjNI0mjPdBUD9");
            //sw.WriteLine("        6auUqlU/KwBZJV4skWUuvMmYV8b+Ls6jQQ81DfryO3KtfUoA/p3810G37T3VJ3TlARdvukhldjANeemx");
            //sw.WriteLine("        z2B8MS0mq80GyySHj98rD2jQOpXbtgrVNprRnO2h5lQX1Sc7leYODh27W3nN9/WZDnroDx0A5wwhdtmt");
            //sw.WriteLine("        AAAAAElFTkSuQmCC");
            //sw.WriteLine("    </value>");
            //sw.WriteLine("  </data>");
            sw.WriteLine("  <data name=\"bindingNavigatorMoveFirstItem.Image\" type=\"System.Drawing.Bitmap, System.Drawing\" mimetype=\"application/x-microsoft.net.object.bytearray.base64\">");
            sw.WriteLine("    <value>");
            sw.WriteLine("        iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8");
            sw.WriteLine("        YQUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAAStJREFUOE9jYBg0");
            sw.WriteLine("        oHDW8/9NC57/z5z4+D8uR4W3P8Apx5A789n/VUfe/8elKL77wf/ghmu4DciY8vT/wn0fsCqK73n4f+n+");
            sw.WriteLine("        ///9qy/gNiCh58n/aVveYyiKaL8P1pw56/9/r9ITuA2I7Hr0v3f1BxRFoa33wJpb1wFt7/z73yX/AG4D");
            sw.WriteLine("        Apsf/q+b/w6uKLjl7v9Fe///7wBqzpjz879d3c//9hnbcRvgUXX/f/60NyiK7Ipv/0+f8/u/f9e3/zqF");
            sw.WriteLine("        7/5bJKzHbYB96d3/2ZNfYyjSTzn/36ToxX+VrE//jSOX4TbAIu/O/9T+11gVGSSd+C+b9vW/bvA83AYY");
            sw.WriteLine("        Zt3+H9byEqci/dTL/zV8p+E2QCftxn+/6od4Fal4TMBtgFPulf8gBXgVDZqMh+wQAPB2wKsSwCgmAAAA");
            sw.WriteLine("        AElFTkSuQmCC");
            sw.WriteLine("</value>");
            sw.WriteLine("  </data>");
            sw.WriteLine("  <data name=\"bindingNavigatorMoveLastItem.Image\" type=\"System.Drawing.Bitmap, System.Drawing\" mimetype=\"application/x-microsoft.net.object.bytearray.base64\">");
            sw.WriteLine("    <value>");
            sw.WriteLine("        iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8");
            sw.WriteLine("        YQUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAATBJREFUOE9jYBhU");
            sw.WriteLine("        oHDW8/+4HASSa1rw/H/mxMc41TDkznz2P6H7HlYFILlVR97/D29/gNuAjClP/8/b//t/QtcdDEUguYX7");
            sw.WriteLine("        PvwPbriG24CEnif/Z+/79b9z69//bqWXURSC5KZtef/fv/oCbgMiux79n7Lt1/+SpX//J0z/+98m9yxc");
            sw.WriteLine("        MUiud/WH/16lJ3AbENj88H/r2vdgzcYlX/5LR1/7bxy5DKwBJFc3/91/l/wDuA3wqLr/v2TuO7hmRZce");
            sw.WriteLine("        uGKQXP60N//tM7bjNsC+9O7/wJZnYJuRNYNcAJLLnvz6v0XCetwGWOTd+W9TcAVDM8gAkFxq/2u4l7Cm");
            sw.WriteLine("        F8Os21g1gxSD5MJaXv7XDZ6H2wU6aTdwSoLk/Kof/tfwnYbbAHz5yin3yn8VjwlgPKjyHwMAvtG/s0Vm");
            sw.WriteLine("        x8MAAAAASUVORK5CYII=");
            sw.WriteLine("</value>");
            sw.WriteLine("  </data>");
            sw.WriteLine("  <data name=\"bindingNavigatorMoveNextItem.Image\" type=\"System.Drawing.Bitmap, System.Drawing\" mimetype=\"application/x-microsoft.net.object.bytearray.base64\">");
            sw.WriteLine("    <value>");
            sw.WriteLine("        iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8");
            sw.WriteLine("        YQUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAAKtJREFUOE9jYBh0");
            sw.WriteLine("        oHDW8/8UOSp35rP/Cd33yDckY8rT//P2//6f0HWHPEMSep78n73v1//OrX//u5VeJt2QyK5H/6ds+/W/");
            sw.WriteLine("        ZOnf/wnT//63yT1LmiGBzQ//t659D9ZsXPLlv3T0tf/GkcuIN8Sj6v7/krnv4JoVXXqI1wyKPvvSu/8D");
            sw.WriteLine("        W56BbSZZM8gAi7w7/20KrpCnGWSAYdZt8jWDDNBJu0GanylKtoNCMwCgfl+gC2KedgAAAABJRU5ErkJg");
            sw.WriteLine("        gg==");
            sw.WriteLine("</value>");
            sw.WriteLine("  </data>");
            sw.WriteLine("  <data name=\"bindingNavigatorMovePreviousItem.Image\" type=\"System.Drawing.Bitmap, System.Drawing\" mimetype=\"application/x-microsoft.net.object.bytearray.base64\">");
            sw.WriteLine("    <value>");
            sw.WriteLine("        iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8");
            sw.WriteLine("        YQUAAAAgY0hSTQAAeiYAAICEAAD6AAAAgOgAAHUwAADqYAAAOpgAABdwnLpRPAAAAL1JREFUOE9jYBgy");
            sw.WriteLine("        ILz9wX+yHRvf/eB/cMM18gyI73n4f+n+///9qy+QbkBE+32w5sxZ//97lZ4gzYDQ1ntgza3rgLZ3/v3v");
            sw.WriteLine("        kn+AeAOCW+7+X7T3//8OoOaMOT//29X9/G+fsZ14A0ChbVd8+3/6nN///bu+/dcpfPffImE9aQaADNFP");
            sw.WriteLine("        Of/fpOjFf5WsT/+NI5eRbgDIEIOkE/9l077+1w2eR54BYJekXv6v4TuNfANAhqh4TKDMALKTMc01AgDQ");
            sw.WriteLine("        FGCYkuTLEQAAAABJRU5ErkJggg==");
            sw.WriteLine("</value>");
            sw.WriteLine("  </data>");
            sw.WriteLine("  <data name=\"bindingNavigatorRLoadInfo.TrayLocation\" type=\"System.Drawing.Point, System.Drawing\">");
            sw.WriteLine("    <value>17, 17</value>");
            sw.WriteLine("  </data>");
            sw.WriteLine("</root>");

            sw.Close();
            file.Close();
        }
    }
}
