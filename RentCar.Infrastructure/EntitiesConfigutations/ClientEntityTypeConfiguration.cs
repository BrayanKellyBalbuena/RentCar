using RentCar.Core.Entities;
using RentCar.Infrastructure.Abstractions;
using RentCar.Infrastructure.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Infrastructure.EntitiesConfigutations
{
    internal class ClientEntityTypeConfiguration : EntityConfiguration<Client>
    {
       

        public ClientEntityTypeConfiguration()
        {
            Property(c => c.CreditCardNumber).HasMaxLength(IdentificationDocumentsLengthNumber.CREDIT_CARD_LENTH);
            Property(c => c.IdentificationCard).HasMaxLength(IdentificationDocumentsLengthNumber.DOMINICAN_REPUBLIC_IDENTIFICACION_CARD_LENGTH);

        }
    }
}
