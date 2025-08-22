using Hangfire;
using Lab02HangfireIntegration.Jobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab02HangfireIntegration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private IBackgroundJobClient _jobClient;

        public JobsController(IBackgroundJobClient jobClient)
        {
            _jobClient = jobClient;
        }

        [HttpGet("fire-forget")]
        public IActionResult Job1()
        {
            //var job = new PrintingJobs();
            //_jobClient.Enqueue(() => 
            //job.PrintMessage("Hello this is long ruuing task"));

            _jobClient.Enqueue<PrintingJobs>(p => p.PrintMessage("Hello again this is long ruuing task"));
            return Ok("fire and forget called");
        }

        [HttpGet("delay")]
        public IActionResult Job2()
        {
            _jobClient.Schedule<PrintingJobs>(p => p.PrintMessage("after 50 seconds"), 
                                    TimeSpan.FromSeconds(50));

            return Ok("this is deplayed job");
        }
        [HttpGet("recurring")]
        public IActionResult Job3() {

            RecurringJob.AddOrUpdate<PrintingJobs>("job3-recurring", (p => p.PrintMessage("cron job")), Cron.Minutely);
            return Ok("recurring jbo called");
        }

        [HttpGet("downloadRssLinks")]
        public IActionResult Job4()
        {
            string jsonFile = @"C:\LiveSessionKoenig\KlineCustom02\kline-batch2\Day4\rssUrls.json";
            string rssUrl = "https://feeds.bbci.co.uk/news/rss.xml";
            _jobClient.Enqueue<RssFeedJobs>(r=>r.PullRssAsync(rssUrl,jsonFile));
            return Ok("json file created");
        }

        [HttpGet("downloadHtml")]
        public IActionResult Job5()
        {
            string jsonFile = @"C:\LiveSessionKoenig\KlineCustom02\kline-batch2\Day4\rssUrls.json";
            string folder  = @"C:\LiveSessionKoenig\KlineCustom02\kline-batch2\Day4\downloads";

           
            _jobClient.Enqueue<RssFeedJobs>(r=>r.SyncHtmlFilesAsync(jsonFile,folder,5));

            return Ok("htmls are queued up");
        }

    }
}
