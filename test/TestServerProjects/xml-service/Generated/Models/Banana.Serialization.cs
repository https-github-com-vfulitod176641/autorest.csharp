// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace xml_service.Models
{
    public partial class Banana : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "banana");
            if (Name != null)
            {
                writer.WriteStartElement("name");
                writer.WriteValue(Name);
                writer.WriteEndElement();
            }
            if (Flavor != null)
            {
                writer.WriteStartElement("flavor");
                writer.WriteValue(Flavor);
                writer.WriteEndElement();
            }
            if (Expiration != null)
            {
                writer.WriteStartElement("expiration");
                writer.WriteValue(Expiration.Value, "O");
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static Banana DeserializeBanana(XElement element)
        {
            string name = default;
            string flavor = default;
            DateTimeOffset? expiration = default;
            if (element.Element("name") is XElement nameElement)
            {
                name = (string)nameElement;
            }
            if (element.Element("flavor") is XElement flavorElement)
            {
                flavor = (string)flavorElement;
            }
            if (element.Element("expiration") is XElement expirationElement)
            {
                expiration = expirationElement.GetDateTimeOffsetValue("O");
            }
            return new Banana(name, flavor, expiration);
        }
    }
}
