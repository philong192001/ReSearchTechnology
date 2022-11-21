using Core.Commands;
using Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartHome.Temperature.TemperatureMeasurements.StartingTemperatureMeasurement
{
    public class StartTemperatureMeasurement : ICommand
    {
        public Guid MeasurementId { get; }

        private StartTemperatureMeasurement(Guid measurementId)
        {
            MeasurementId = measurementId;
        }

        public static StartTemperatureMeasurement Create(Guid measurementId)
        {
            if (measurementId == Guid.Empty)
                throw new ArgumentOutOfRangeException(nameof(measurementId));

            return new StartTemperatureMeasurement(measurementId);
        }
    }

    public class HandleStartTemperatureMeasurement :
    ICommandHandler<StartTemperatureMeasurement>
    {
        private readonly IRepository<TemperatureMeasurement> repository;

        public HandleStartTemperatureMeasurement(
            IRepository<TemperatureMeasurement> repository
        )
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(StartTemperatureMeasurement command, CancellationToken cancellationToken)
        {
            var reservation = TemperatureMeasurement.Start(
                command.MeasurementId
            );

            await repository.Add(reservation, cancellationToken);

            return Unit.Value;
        }
    }
}
