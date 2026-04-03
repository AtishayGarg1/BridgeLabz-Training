using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.DSA_FOLDER.scenariobased.parcelTracker
{
    internal interface ITrackable
    {
        void AddStage(string stageName);
        void InsertCheckPoint(string prevStage, string nextStage);
        void TrackForward();
        void MarkLost(string stageName);
        string GetCurrentStage();
    }
}
