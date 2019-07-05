using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StockTruckManagementBraydenRoberts.Models.DB
{
    class DAO
    {

        public TruckModel searchTruckModelByID(int id)
        {
            using (var ctx = new GSQ2_Brayden_ProjectContext())
            {
                TruckModel model = ctx.TruckModel.FromSql<TruckModel>("searchTruckModelByID @P0", id).FirstOrDefault();
                return model;
            }
        }

        public TruckData searchTruckDetailByID(int id)
        {
            using (var ctx = new GSQ2_Brayden_ProjectContext())
            {
                TruckData data = ctx.TruckData.FromSql("SearchTruckDetailByID @p0", id).FirstOrDefault();
                return data;
            }
        }

        public void addNewTruckModel(IndividualTruck truck)
        {
            using(GSQ2_Brayden_ProjectContext ctx = new GSQ2_Brayden_ProjectContext())
            {
                ctx.IndividualTruck.Add(truck);
                ctx.SaveChanges();
            }
        }


        public void updateTruckModel(TruckModel tk)
        {
            using (GSQ2_Brayden_ProjectContext ctx = new GSQ2_Brayden_ProjectContext())
            {
                ctx.Entry(tk).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.Entry(tk.IndividualTruck).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.SaveChanges();
            }


        }

        public List<TruckModel> getTruckModels()
        {
            using (GSQ2_Brayden_ProjectContext ctx = new GSQ2_Brayden_ProjectContext())
            {
                return ctx.TruckModel.ToList();
            }
        }

        public List<TruckFeature> getTruckFeature()
        {
            using(GSQ2_Brayden_ProjectContext ctx = new GSQ2_Brayden_ProjectContext())
            {
                return ctx.TruckFeature.ToList();

            }
        }

        public IndividualTruck searchTruckbyID(int truckId)
        {
            using (GSQ2_Brayden_ProjectContext ctx = new GSQ2_Brayden_ProjectContext())
            {
                return ctx.IndividualTruck.Where(c => c.TruckId == truckId).FirstOrDefault();

            }
        }

        public void updateTruck(IndividualTruck tk)
        {
            using (GSQ2_Brayden_ProjectContext ctx = new GSQ2_Brayden_ProjectContext())
            {
                ctx.Entry(tk).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.Entry(tk.TruckFeatureAssociation).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public List<TruckModel> getAllTruckData()
        {
            using (GSQ2_Brayden_ProjectContext ctx = new GSQ2_Brayden_ProjectContext())
            {
                List<TruckModel> data = ctx.IndividualTruck.Include(m => m.TruckModel).Select(x => new TruckModel()
                {
                    Model = x.TruckModel.Model,
                    Manufacturer = x.TruckModel.Manufacturer,
                    Size = x.TruckModel.Size,
                    Seats = x.TruckModel.Seats,
                    Doors = x.TruckModel.Doors

                            /*public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Size { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }*/
                }).ToList();
                return data;
            }
        }

        



  




    }
}
