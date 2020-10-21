// This file should be place in a separate project

using MainNameSpace;

namespace SecondNameSpace
{
    class ClassThree
    {
        void AMethod()
        {
            ClassOne c1 = new ClassOne();
            // can access c1.x
            // cannot access c1.y
            // cannot access c1.z

            // can call c1.MethodOne();
            // cannot call c1.MethodTwo();
            // cannot call c1.MethodThree();
        }
    }
}
