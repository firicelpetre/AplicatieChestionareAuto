using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieChestionareAuto
{
    public  class ChestionarService
    {
        public List<IntrebareChestionar> listaIntrebariChestionar;

        public ChestionarService() 
        {
            listaIntrebariChestionar = GetIntrebari();
            
        }

        public static List<IntrebareChestionar> ReadProductsFromCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csvReader.Context.RegisterClassMap<IntrebareChestionarMap>();
                return csvReader.GetRecords<IntrebareChestionar>().ToList();
            }
        }

        public static List<IntrebareChestionar> GetIntrebari()
        {
            string path = CsvDataPath.filePath_ChestionareTip_A;
            return ReadProductsFromCsv(path);

        }
    }

    public sealed class IntrebareChestionarMap : ClassMap<IntrebareChestionar>
    {
        public IntrebareChestionarMap()
        {
            Map(m => m.enuntIntrebare).Name("enuntIntrebare");
            Map(m => m.variantaA).Name("variantaA");
            Map(m => m.variantaB).Name("variantaB");
            Map(m => m.variantaC).Name("variantaC");
            Map(m => m.raspunsCorect).Name("raspunsCorect");
            
        }
    }
}

