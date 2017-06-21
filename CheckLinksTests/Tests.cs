using System;
using System.Linq;
using Xunit;

namespace CheckLinksTests
{
    public class Tests
    {
        [Fact]
        public void WithoutHttpAtStartOfLink_NoLinks()
        {
            var links = LinkChecker.GetLinks("<a href=\"google.com\" />");

            Assert.Equal(links.Count(), 0); 
            //Assert.Equal(links.First(), "google.com");
        }
		[Fact]
		public void WithHttpAtStartOfLink_LinksParses()
		{
			var links = LinkChecker.GetLinks("<a href=\"http://google.com\" />");

			Assert.Equal(links.Count(), 1);
			Assert.Equal(links.First(), "http://google.com");
		}
	}
}
