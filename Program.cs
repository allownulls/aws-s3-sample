using System.Threading.Tasks;


namespace AmazonS3Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                await S3Sample.Test();
            }).GetAwaiter().GetResult();
                      
        }
    }
}



