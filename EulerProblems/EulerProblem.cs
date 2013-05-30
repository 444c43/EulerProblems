using System;
using Extensions;
using Services;
using System.Collections;
using System.Collections.Generic;

namespace EulerProblems
{
    public class EulerProblem<T>
    {
        #region fields
        protected string Name { get; set; }
        protected string Title { get; set; }

        public T[] Results { get; set; }
        public T InputValue { get; set; }

        protected List<string> ProblemDescription { get; set; }
        protected List<string> EulerInstructions { get; set; }

        protected Output Output { get; set; }
        protected Input Input { get; set; }
        protected Validation Validation { get; set; }
        #endregion

        public EulerProblem()
        {
            Results = new T[]{};
            Output = new Output();
            Input = new Input();
            Validation = new Validation();
        }

        public virtual void EulerMain()
        {
            DisplayProblemAndInstructions();
        }

        public T ValidateInput()
        {
            string UserInput = Input.GetUserInput();
            object result = null;
            try
            {
                if (InputValue.GetType() == typeof(int))
                    result = int.Parse(UserInput);
                if (InputValue.GetType() == typeof(long))
                    result = long.Parse(UserInput);
            }
            catch (Exception ex) 
            {
                EulerMain();
                ValidateInput();
            }

            return (T)result;
        }

        #region Private Methods
        private void DisplayProblemAndInstructions()
        {
            Output.ClearConsole();
            Output.DisplayList(ProblemDescription);
            Output.LineBreak();
            Output.DisplayList(EulerInstructions);
            Output.LineBreak();
        }

        private int CalculateIterative(int value)
        {
            return 0;
        }

        private int CalculateEfficient(int value)
        {
            return 0;
        }
        #endregion
    }
}
