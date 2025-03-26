using Common.Domain;
using System.Diagnostics;

namespace Server.SystemOperation
{
    public class LogInSO : SystemOperationBase
    {
        private ZdravstveniRadnik zRadnik;
        public ZdravstveniRadnik Result { get; private set; }
        public bool IsSuccessful { get; private set; }

        public LogInSO(ZdravstveniRadnik zRadnik)
        {
            this.zRadnik = zRadnik;
        }

        protected override void ExecuteConcreteOperation()
        {
            try
            {
                List<IEntity> rezultat = broker.logInUcitavanje(zRadnik);

                if (rezultat.Count > 0 && rezultat[0] is ZdravstveniRadnik radnik)
                {
                    Result = radnik;
                    IsSuccessful = true;
                }
                else
                {
                    Result = null;
                    IsSuccessful = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Greška!");
                IsSuccessful = false;
                Result = null;
            }


            if (Result == null)
            {
                Debug.WriteLine("Logovanje nije uspelo.");
            }
            else
            {
                Debug.WriteLine($"Prijavljeni zdravstveni radnik: {Result.KorisnickoIme}");
            }
        }

    }


}
