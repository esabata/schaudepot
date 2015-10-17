using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Dapper;
using Schaudepots.Api.Models;

namespace Schaudepots.Api.Data
{
    public class SlideRepository : ISlideRepository
    {
        private readonly IDbConnectionFactory dbConnectionFactory;

        public SlideRepository(IDbConnectionFactory dbConnectionFactory)
        {
            this.dbConnectionFactory = dbConnectionFactory;
        }

        public IList<SlideModel> Get()
        {
            using (var conn = dbConnectionFactory.CreateConnection())
            {

                var slides = conn.Query<SlideModel>(
                        "SELECT * FROM Slide"
                    ).ToList();

                slides.ForEach(s =>
                {
                    s.Slides = conn.Query<ValueModel>(
                            "SELECT * FROM Value WHERE SlideId=@SlideId",
                            new { SlideId = s.Id }
                        ).ToList();
                });

                return slides;
            }
        } 
    }
}