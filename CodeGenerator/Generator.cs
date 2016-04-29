﻿using System.IO;
using System.Linq;
using System.Text;

namespace CodeGenerator
{
    public class Generator
    {
        public string GenerateBusinessObject(GeneratorConfiguration config)
        {
            var text = new StringBuilder(File.ReadAllText("Resources/BusinessObjectExample.cs"));
            text.Replace("<!NAMESPACE!>", config.Namespace);
            text.Replace("<!BUSINESSOBJECTNAME!>", config.BusinessObjectName);
            text.Replace("<!PROPERTIES!>", string.Join("\n        \n", config.Variables.Select(vari => vari.GetPropertyDefinition())));

            return text.ToString();
        }

        public string GenerateMapper(GeneratorConfiguration config)
        {
            var text = new StringBuilder(File.ReadAllText("Resources/MapperExample.cs"));
            text.Replace("<!NAMESPACE!>", config.Namespace);
            text.Replace("<!BUSINESSOBJECTNAME!>", config.BusinessObjectName);
            text.Replace("<!BONAMEPARAMETER!>", config.BusinessObjectNameAsParameter);
            text.Replace("<!BYTEARRAYSIZE!>", config.ByteArraySize.ToString());
            text.Replace("<!MAPFROMCOBOL!>", string.Join("\n        \n", config.Variables.Select(vari => vari.GetMappingFromCobol())));
            text.Replace("<!MAPTOCOBOL!>", string.Join("\n        \n", config.Variables.Select(vari => vari.GetMappingToCobol(config.BusinessObjectNameAsParameter))));

            return text.ToString();
        }
    }
}