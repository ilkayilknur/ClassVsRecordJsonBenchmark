using System.Text.Json;
using BenchmarkDotNet.Attributes;

namespace ClassVsRecordJsonBenchmark
{
    public class JsonBenchmark
    {
        private SampleModelClass sampleClass;
        private SampleModelRecord sampleRecord;
        private string sampleJson;

        [GlobalSetup]
        public void Setup()
        {
            sampleClass = new SampleModelClass()
            {
                Id = 1,
                Name = "Ilkay",
                Surname = "Ilknur"
            };
            
             sampleRecord  = new SampleModelRecord(1, "Ilkay", "Ilknur");
             
             sampleJson = JsonSerializer.Serialize(new SampleModelClass()
             {
                 Id = 1,
                 Name = "Ilkay",
                 Surname = "Ilknur"
             });
        }

        [Benchmark]
        public string SerializeRecord()
        {
            return JsonSerializer.Serialize(sampleRecord);
        }

        [Benchmark]
        public string SerializeClass()
        {
            return JsonSerializer.Serialize(sampleClass);
        }
        
        [Benchmark]
        public SampleModelRecord DeserializeRecord()
        {
            return JsonSerializer.Deserialize<SampleModelRecord>(sampleJson);
        }

        [Benchmark]
        public SampleModelClass DeserializeClass()
        {
            return JsonSerializer.Deserialize<SampleModelClass>(sampleJson);
        }
    }

    public class SampleModelClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public record SampleModelRecord(int Id, string Name, string Surname);
}