namespace Calculator
{
    public class LogCalculator
    {
        public void validateInput(float x)
        {
            if (x <= 0)
                throw new Exception("Wrong parameters");
        }

        public void calcLog(ref float output, float x)
        {
            validateInput(x);
            output = (float) Math.Log(x);
        }

        public void sumLogs(ref float output, float xa, float xb)
        {
            validateInput(xa);
            validateInput(xb);
            output = (float)(Math.Log(xa * xb));
        }

        public void substractLogs(ref float output, float xa, float xb)
        {
            validateInput(xa);
            validateInput(xb);
            output = (float)(Math.Log(xa / xb));
        }
        // формули множення немає начебто

        public void calcLogXY(ref float output, float x, float y)
        {
            validateInput(x);
            validateInput(y);
            output = (float)(Math.Log(x) / Math.Log(y));
        }

    }
}
