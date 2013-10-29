/******************************************************************************* 
 *  Copyright 2009 Amazon Services. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 * 
 *  FBA Inventory Service MWS CSharp Library
 *  API Version: 2010-10-01
 *  Generated: Fri Oct 22 09:53:30 UTC 2010 
 * 
 */

using System;
using System.Xml.Serialization;
using System.Text;

namespace AmazonAccess.Services.FbaInventoryServiceMws.Model
{
    [XmlType(Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/")]
    [XmlRoot(Namespace = "http://mws.amazonaws.com/FulfillmentInventory/2010-10-01/", IsNullable = false)]
    public class Error
    {
    
        private String typeField;

        private String codeField;

        private String messageField;

        private  Object detailField;

        /// <summary>
        /// Gets and sets the Type property.
        /// </summary>
        [XmlElement(ElementName = "Type")]
        public String Type
        {
            get { return this.typeField ; }
            set { this.typeField= value; }
        }



        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">Type property</param>
        /// <returns>this instance</returns>
        public Error WithType(String type)
        {
            this.typeField = type;
            return this;
        }



        /// <summary>
        /// Checks if Type property is set
        /// </summary>
        /// <returns>true if Type property is set</returns>
        public Boolean IsSetType()
        {
            return this.typeField != null;

        }


        /// <summary>
        /// Gets and sets the Code property.
        /// </summary>
        [XmlElement(ElementName = "Code")]
        public String Code
        {
            get { return this.codeField ; }
            set { this.codeField= value; }
        }



        /// <summary>
        /// Sets the Code property
        /// </summary>
        /// <param name="code">Code property</param>
        /// <returns>this instance</returns>
        public Error WithCode(String code)
        {
            this.codeField = code;
            return this;
        }



        /// <summary>
        /// Checks if Code property is set
        /// </summary>
        /// <returns>true if Code property is set</returns>
        public Boolean IsSetCode()
        {
            return  this.codeField != null;

        }


        /// <summary>
        /// Gets and sets the Message property.
        /// </summary>
        [XmlElement(ElementName = "Message")]
        public String Message
        {
            get { return this.messageField ; }
            set { this.messageField= value; }
        }



        /// <summary>
        /// Sets the Message property
        /// </summary>
        /// <param name="message">Message property</param>
        /// <returns>this instance</returns>
        public Error WithMessage(String message)
        {
            this.messageField = message;
            return this;
        }



        /// <summary>
        /// Checks if Message property is set
        /// </summary>
        /// <returns>true if Message property is set</returns>
        public Boolean IsSetMessage()
        {
            return  this.messageField != null;

        }


        /// <summary>
        /// Gets and sets the Detail property.
        /// </summary>
        [XmlElement(ElementName = "Detail")]
        public Object Detail
        {
            get { return this.detailField ; }
            set { this.detailField = value; }
        }



        /// <summary>
        /// Sets the Detail property
        /// </summary>
        /// <param name="detail">Detail property</param>
        /// <returns>this instance</returns>
        public Error WithDetail(Object detail)
        {
            this.detailField = detail;
            return this;
        }



        /// <summary>
        /// Checks if Detail property is set
        /// </summary>
        /// <returns>true if Detail property is set</returns>
        public Boolean IsSetDetail()
        {
            return this.detailField != null;
        }






        /// <summary>
        /// XML fragment representation of this object
        /// </summary>
        /// <returns>XML fragment for this object.</returns>
        /// <remarks>
        /// Name for outer tag expected to be set by calling method. 
        /// This fragment returns inner properties representation only
        /// </remarks>


        protected internal String ToXMLFragment() {
            StringBuilder xml = new StringBuilder();
            if (this.IsSetType()) {
                xml.Append("<Type>");
                xml.Append(this.Type);
                xml.Append("</Type>");
            }
            if (this.IsSetCode()) {
                xml.Append("<Code>");
                xml.Append(this.EscapeXML(this.Code));
                xml.Append("</Code>");
            }
            if (this.IsSetMessage()) {
                xml.Append("<Message>");
                xml.Append(this.EscapeXML(this.Message));
                xml.Append("</Message>");
            }
            if (this.IsSetDetail()) {
                Object  detailObj = this.Detail;
                xml.Append("<Detail>");
                xml.Append(detailObj.ToString());
                xml.Append("</Detail>");
            } 
            return xml.ToString();
        }

        /**
         * 
         * Escape XML special characters
         */
        private String EscapeXML(String str) {
            StringBuilder sb = new StringBuilder();
            foreach (Char c in str)
            {
                switch (c) {
                case '&':
                    sb.Append("&amp;");
                    break;
                case '<':
                    sb.Append("&lt;");
                    break;
                case '>':
                    sb.Append("&gt;");
                    break;
                case '\'':
                    sb.Append("&#039;");
                    break;
                case '"':
                    sb.Append("&quot;");
                    break;
                default:
                    sb.Append(c);
                    break;
                }
            }
            return sb.ToString();
        }



    }

}