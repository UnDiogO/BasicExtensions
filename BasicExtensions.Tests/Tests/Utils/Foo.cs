namespace BasicExtensions.Tests
{
    /// <summary>
    /// To be added.
    /// </summary>
    public class Foo
    {
        /// <summary>
        /// To be added.
        /// </summary>
        public static string Bar { get; set; }

        /// <summary>
        /// To be added.
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// To be added.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// To be added.
        /// </summary>
        public Foo() { }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="text"></param>
        public Foo(int number, string text)
        {
            Number = number;
            Text = text;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <returns></returns>
        public override string ToString() =>
            this.ToHumanReadable();
    }
}