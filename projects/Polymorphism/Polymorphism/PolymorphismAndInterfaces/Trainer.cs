using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismAndInterfaces
{
    class Trainer
    {
        private IAnimal entity;

        public Trainer(IAnimal entity)
        {
            this.entity = entity;
        }

        public string Male()
        {
            return entity.Perform();
        }
    }
}
