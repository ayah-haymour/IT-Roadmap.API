using Dapper;
using IT_Roadmap.Core.Common;
using IT_Roadmap.Core.Data;
using IT_Roadmap.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Roadmap.Infra.Repository
{
    public class TestmonialRepository : ITestmonialRepository
    {
        private readonly IDbContext dbContext;

        public TestmonialRepository(IDbContext _dbContext)
        {
            this.dbContext = _dbContext;
        }

        public List<Testimonial> GetAllUsertestimonials()
        {
            IEnumerable<Testimonial> result = dbContext.Connection.Query<Testimonial>("testimonial_package.GetAlltestimonials", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Testimonial GetUsertestimonialById(decimal id)
        {
            var p = new DynamicParameters();
            p.Add("Testimonial_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Query<Testimonial>("testimonial_package.GettestimonialById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void CreateUsertestimonial(Testimonial testimonialData)
        {
            var p = new DynamicParameters();
            p.Add("User_ID", testimonialData.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Testimonial_Text", testimonialData.Testimonialtext, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("testimonial_package.Createtestimonial", p, commandType: CommandType.StoredProcedure);
        }

        public void UpdateUsertestimonial(Testimonial testimonialData)
        {
            var p = new DynamicParameters();
            p.Add("Testimonial_ID", testimonialData.Testimonialid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("User_ID", testimonialData.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Testimonial_Text", testimonialData.Testimonialtext, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("STATUS_", testimonialData.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("testimonial_package.Updatetestimonial", p, commandType: CommandType.StoredProcedure);
        }
        public void AcceptOrRejectTestimonial(Testimonial testimonialData)
        {
            var p = new DynamicParameters();
            p.Add("ID", testimonialData.Testimonialid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("status_", testimonialData.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("testimonial_package.AcceptOrRejectTestimonial", p, commandType: CommandType.StoredProcedure);
        }
        public void DeleteUsertestimonial(decimal id)
        {
            var p = new DynamicParameters();
            p.Add("Testimonial_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.Execute("testimonial_package.Deletetestimonial", p, commandType: CommandType.StoredProcedure);
        }
    }
}
