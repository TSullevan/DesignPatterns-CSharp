namespace Builder
{
    public class Director
    {
        public Dog Construct(IBuilder builder)
        {
            if (builder.GetColor() == null)
            {
                builder.SetColor("White");
            }
            if (builder.GetName() == null)
            {
                builder.SetName("Default name");
            }
            return builder.Build();
        }
    }
}
