using System;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;


namespace InfallibleEngine
{
    public class PageElement
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        public ObjectId DocumentObjectID { get; set; }
        [BsonElement("tagname")]
        public string Tagname { get; set; }
        [BsonElement("type")]
        public string Type { get; set; }
        [BsonElement("html_id")]
        public string HtmlID { get; set; }
        [BsonElement("src")]
        public string Src { get; set; }
        [BsonElement("href")]
        public string Href { get; set; }
		[BsonElement("name")]
		public string Name { get; set; }
        [BsonElement("alt")]
        public string Alt { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("text_content")]
        public string TextContent { get; set; }
        [BsonElement("checked")]
        public string Checked { get; set; }
        [BsonElement("selected_index")]
        public string SelectedIndex { get; set; }
        [BsonElement("selected_text")]
        public string SelectedText { get; set; }
        [BsonElement("html_class")]
        public string HtmlClass { get; set; }
        [BsonElement("value")]
        public string Value { get; set; }
        [BsonElement("onclick")]
        public string Onclick { get; set; }
        [BsonElement("onblur")]
        public string Onblur { get; set; }
        [BsonElement("onchange")]
        public string Onchange { get; set; }
        [BsonElement("onkeypress")]
        public string Onkeypress { get; set; }
        [BsonElement("child_window")]
        public string ChildWindow { get; set; }
        [BsonElement("html")]
        public string Html { get; set; }
        [BsonElement("arrived_by_link")]
        public string ArrivedByLink { get; set; }

        /*public PageElement()
        {

        }*/


    }
}
