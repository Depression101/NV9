using System;
using System.Collections.Generic;
using System.Text;

namespace NV_Prezentace.CompositeFolder
{
    class Composite : Component
    {
        private List<Component> components;
        public Composite()
        {
            components = new List<Component>();
        }
        public void AddComponent(Component component)
        {
            components.Add(component);
        }
        public void RemoveComponent(Component component)
        {
            components.Remove(component);
        }
        public void DoSomething()
        {
            foreach(Component component in components)
            {
                component.DoSomething();
            }
        }
    }
}
