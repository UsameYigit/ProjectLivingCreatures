using ProjectLivingCreatures.LivingCreatureClasses.Plants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLivingCreatures
{
    class Plant : LivingCreature
    {
        string _flowerColor;
        public string FlowerColor
        {
            get => _flowerColor;
            set => _flowerColor = value;
        }
        PlantTypes _plantTypes;
        public PlantTypes PlantTypes
        {
            get => _plantTypes;
            set => _plantTypes = value;
        }
        

        public Plant()
        {
            this.Type = Types.Plant;
        }

        public string Photosynthesis()
        {
            return "All the plants can do Photosynthesis, and they do this via same method.";
        }

        public override string Breath()
        {
            return "It's one of the most basic elemnts of life, and yes plants can breath as well.";
        }

        public override string Move()
        {
            return "They can't walk or fly, but they surely can move.";
        }

        public override string Reproduce()
        {
            return "Most of the plants reproduce via polens.";
        }
    }
}
