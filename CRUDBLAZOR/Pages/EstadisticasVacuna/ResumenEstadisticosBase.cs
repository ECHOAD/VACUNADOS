using CRUDBLAZOR.Models.ComboBoxModels;
using CRUDBLAZOR.Models;
using DataLibrary;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBLAZOR.Pages
{
    public class ResumenEstadisticosBase : ComponentBase
    {

        protected bool AllLoaded = false;
        [Inject]
        private IDataAccess _data { get; set; }
        [Inject]
        private IConfiguration _config { get; set; }
        protected List<dynamic> _cboProvincia { get; set; }
        protected List<dynamic> VacunadosProv = null;
        protected List<dynamic> Vacunadosmarcas { get; set; }
        protected List<dynamic> VacunadosSignos { get; set; }
        protected double[] data { get; set; }
        protected string[] labels { get; set; }
        protected int dataSize;
        protected int Index = -1;

        protected string Id_provincia = "";

        protected override async Task OnInitializedAsync()
        {
            var query = "SELECT * FROM PROVINCIA";
            _cboProvincia = await _data.LoadData<dynamic, dynamic>(query, new { }, _config.GetConnectionString("default"));


            query = "SELECT * FROM VW_LIST_VACUNADOS_BY_VACUNA";
            Vacunadosmarcas = await _data.LoadData<dynamic, dynamic>(query, new { }, _config.GetConnectionString("default"));


            dataSize = Vacunadosmarcas.Count;
            data = new double[Vacunadosmarcas.Count];
            labels = new string[Vacunadosmarcas.Count];

            for (int i = 0; i < Vacunadosmarcas.Count; i++)
            {
                labels[i] = Vacunadosmarcas[i].Marca;
                data[i] = Vacunadosmarcas[i].Cant_vacunados;

            }

            query = "SELECT Nombre,Cant_vacunados From VW_LIST_VACUNADOS_BY_SIGNO";
            VacunadosSignos = await _data.LoadData<dynamic, dynamic>(query, new { }, _config.GetConnectionString("default"));
            AllLoaded = true;

        }


        protected async Task ListarVacunadosProv()
        {



            var query = "SP_LIST_VACUNADOS_PROVINCIA @Provincia_Id";
            VacunadosProv = await _data.LoadData<dynamic, dynamic>(query, new { Provincia_Id = Id_provincia }, _config.GetConnectionString("default"));
            await OnInitializedAsync();

        }



    }
}
