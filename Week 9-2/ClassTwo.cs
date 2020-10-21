namespace MainNameSpace
{
class ClassTwo
{
    void AMethod()
    {
        ClassOne c1 = new ClassOne();
            // can access c1.x
            // can access c1.y
            // cannot access c1.z

            // can call c1.MethodOne();
            // can call c1.MethodTwo();
            // cannot call c1.MethodThree();
        }
    }
}
