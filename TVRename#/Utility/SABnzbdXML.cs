﻿// 
// Main website for TVRename is http://tvrename.com
// 
// Source code available at http://code.google.com/p/tvrename/
// 
// This code is released under GPLv3 http://www.gnu.org/licenses/gpl.html
// 

// 
// The initial version of this source code was auto-generated by xsd, Version=2.0.50727.1432.
// 
// Save http://localhost:8080/sabnzbd/api?mode=queue&apikey=...&start=0&limit=9999&output=xml as sab.xml
// xsd.exe sab.xml
// xsd.exe sab.xsd /c /edb

using System.IO;
using System.Xml.Serialization;

namespace TVRename.SAB
{
    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class queue // : object, System.ComponentModel.INotifyPropertyChanged
    {
        public static queue Deserialize(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            XmlSerializer serializer = new XmlSerializer(typeof (queue));
            try
            {
                queue r = (queue) serializer.Deserialize(ms);
                return r;
            }
            catch
            {
                return null;
            }
        }

        public string uniconfig { get; set; }
        public string cache_size { get; set; }
        public string active_lang { get; set; }
        public string paused { get; set; }
        public string session { get; set; }
        public string restart_req { get; set; }
        public string power_options { get; set; }
        public string speed { get; set; }
        public string helpuri { get; set; }
        public string size { get; set; }
        public string uptime { get; set; }
        public string refresh_rate { get; set; }
        public string my_home { get; set; }
        public string limit { get; set; }
        public string have_quota { get; set; }
        public string isverbose { get; set; }
        public string start { get; set; }
        public string finish { get; set; }
        public string version { get; set; }
        public string new_rel_url { get; set; }
        public string my_lcldata { get; set; }
        public string color_scheme { get; set; }
        public string diskspacetotal1 { get; set; }
        public string nt { get; set; }
        public string status { get; set; }
        public string last_warning { get; set; }
        public string have_warnings { get; set; }
        public string cache_art { get; set; }
        public string sizeleft { get; set; }
        public string finishaction { get; set; }
        public string paused_all { get; set; }
        public string quota { get; set; }
        public string newzbin_url { get; set; }
        public string new_release { get; set; }
        public string pause_int { get; set; }
        public string mbleft { get; set; }
        public string diskspace1 { get; set; }
        public string scripts { get; set; }
        public string darwin { get; set; }
        public string timeleft { get; set; }
        public string mb { get; set; }
        public string noofslots { get; set; }
        public string eta { get; set; }
        public string diskspacetotal2 { get; set; }
        public string nzb_quota { get; set; }
        public string loadavg { get; set; }
        public string cache_max { get; set; }
        public string kbpersec { get; set; }
        public string speedlimit { get; set; }
        public string webdir { get; set; }
        public string queue_details { get; set; }
        public string left_quota { get; set; }
        public string diskspace2 { get; set; }
        public queueSlotsSlot[] slots { get; set; }
        public queueCategories[] categories { get; set; }
    }


    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class queueSlotsSlot // : object, System.ComponentModel.INotifyPropertyChanged
    {
        public string status { get; set; }
        public string index { get; set; }
        public string eta { get; set; }
        public string missing { get; set; }
        public string avg_age { get; set; }
        public string script { get; set; }
        public string msgid { get; set; }
        public string verbosity { get; set; }
        public double mb { get; set; }
        public string sizeleft { get; set; }
        public string filename { get; set; }
        public string priority { get; set; }
        public string cat { get; set; }
        public double mbleft { get; set; }
        public string timeleft { get; set; }
        public string percentage { get; set; }
        public string nzo_id { get; set; }
        public string unpackopts { get; set; }
        public string size { get; set; }
    }


    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class queueCategories
    {

        public string category { get; set; }
    }

    [System.SerializableAttribute]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public class result
    {
        public static result Deserialize(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            XmlSerializer serializer = new XmlSerializer(typeof (result));
            try
            {
                result r = (result) serializer.Deserialize(ms);
                return r;
            }
            catch
            {
                return null;
            }
        }

        public string status { get; set; }
        public string error { get; set; }
    }
} // namespace