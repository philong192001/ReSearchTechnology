using Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SmartHome.Temperature.MotionSensors.InstallingMotionSensor
{
    public class MotionSensorInstalled : IEvent
    {
        public Guid MotionSensorId { get; }

        public DateTime InstalledAt { get; }

        [JsonConstructor]
        private MotionSensorInstalled(
            Guid motionSensorId,
            DateTime installedAt
        )
        {
            MotionSensorId = motionSensorId;
            InstalledAt = installedAt;
        }

        public static MotionSensorInstalled Create(
            Guid motionSensorId,
            DateTime installedAt
        )
        {
            if (motionSensorId == Guid.Empty)
                throw new ArgumentOutOfRangeException(nameof(motionSensorId));
            if (installedAt == default)
                throw new ArgumentOutOfRangeException(nameof(installedAt));

            return new MotionSensorInstalled(motionSensorId, installedAt);
        }
    }
}
