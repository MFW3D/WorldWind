﻿using System.Xml.Serialization;

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.topografix.com/GPX/1/1")]
[System.Xml.Serialization.XmlRootAttribute("gpx", Namespace="http://www.topografix.com/GPX/1/1", IsNullable=false)]
public class gpxType {
     

    /// <remarks/>
    public metadataType metadata;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("wpt")]
    public wptType[] wpt;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("rte")]
    public rteType[] rte;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("trk")]
    public trkType[] trk;
    
    /// <remarks/>
    public extensionsType extensions;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    // GK, 05-feb-20: removed default value attribute, as Garmin MapSource seems to need explicit version attribute
    // [System.ComponentModel.DefaultValueAttribute("1.1")]
    public string version = "1.1";
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string creator;
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.topografix.com/GPX/1/1")]
public class metadataType {
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public string desc;
    
    /// <remarks/>
    public personType author;
    
    /// <remarks/>
    public copyrightType copyright;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link")]
    public linkType[] link;
    
    /// <remarks/>
    public System.DateTime time;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSpecified;
    
    /// <remarks/>
    public string keywords;
    
    /// <remarks/>
    public boundsType bounds;
    
    /// <remarks/>
    public extensionsType extensions;
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.topografix.com/GPX/1/1")]
public class personType {
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public emailType email;
    
    /// <remarks/>
    public linkType link;
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.topografix.com/GPX/1/1")]
public class emailType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string domain;
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.topografix.com/GPX/1/1")]
public class trksegType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("trkpt")]
    public wptType[] trkpt;
    
    /// <remarks/>
    public extensionsType extensions;
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.topografix.com/GPX/1/1")]
public class wptType {
    
    /// <remarks/>
    public System.Decimal ele;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool eleSpecified;
    
    /// <remarks/>
    public System.DateTime time;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSpecified;
    
    /// <remarks/>
    public System.Decimal magvar;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool magvarSpecified;
    
    /// <remarks/>
    public System.Decimal geoidheight;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool geoidheightSpecified;
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public string cmt;
    
    /// <remarks/>
    public string desc;
    
    /// <remarks/>
    public string src;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link")]
    public linkType[] link;
    
    /// <remarks/>
    public string sym;
    
    /// <remarks/>
    public string type;
    
    /// <remarks/>
    public fixType fix;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool fixSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
    public string sat;
    
    /// <remarks/>
    public System.Decimal hdop;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool hdopSpecified;
    
    /// <remarks/>
    public System.Decimal vdop;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool vdopSpecified;
    
    /// <remarks/>
    public System.Decimal pdop;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool pdopSpecified;
    
    /// <remarks/>
    public System.Decimal ageofdgpsdata;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ageofdgpsdataSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string dgpsid;
    
    /// <remarks/>
    public extensionsType extensions;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Decimal lat;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Decimal lon;
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.topografix.com/GPX/1/1")]
public class linkType {
    
    /// <remarks/>
    public string text;
    
    /// <remarks/>
    public string type;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string href;
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.topografix.com/GPX/1/1")]
public enum fixType {
    
    /// <remarks/>
    none,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2d")]
    Item2d,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3d")]
    Item3d,
    
    /// <remarks/>
    dgps,
    
    /// <remarks/>
    pps,
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.topografix.com/GPX/1/1")]
public class extensionsType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any;
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.topografix.com/GPX/1/1")]
public class trkType {
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public string cmt;
    
    /// <remarks/>
    public string desc;
    
    /// <remarks/>
    public string src;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link")]
    public linkType[] link;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
    public string number;
    
    /// <remarks/>
    public string type;
    
    /// <remarks/>
    public extensionsType extensions;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("trkseg")]
    public trksegType[] trkseg;
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.topografix.com/GPX/1/1")]
public class rteType {
    
    /// <remarks/>
    public string name;
    
    /// <remarks/>
    public string cmt;
    
    /// <remarks/>
    public string desc;
    
    /// <remarks/>
    public string src;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link")]
    public linkType[] link;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
    public string number;
    
    /// <remarks/>
    public string type;
    
    /// <remarks/>
    public extensionsType extensions;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("rtept")]
    public wptType[] rtept;
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.topografix.com/GPX/1/1")]
public class boundsType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Decimal minlat;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Decimal minlon;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Decimal maxlat;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Decimal maxlon;
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.topografix.com/GPX/1/1")]
public class copyrightType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="gYear")]
    public string year;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
    public string license;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string author;
}
