using System;

namespace ExamplesLibrary.Types.Classes
{
    interface IPlayerBehavior
    {
        public void Walk(int x, int y);
        public void Attack();
    }
}
