
            Task task = Task.Run(() => {

                for (int i = 1; i <= 10000; i++)
                {
                   Invoke(new Action(() =>
                   {
                       progressBar1.Value = i; // 여기가 문제 

                   })); //invoke를 줘라
                   
                    Thread.Sleep(1);
                }

            }); // 하나의 스레드 
