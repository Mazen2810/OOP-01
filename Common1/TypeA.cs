using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common1
{
    //// What can you write inside the Namespace?
    //// 1. Class
    //// 2. Struct [Stands for Struture]
    //// 3. Interface
    //// 4. Enum
    //// 5. Delegate
    //// 6. Record [C# 9.0 New feature (.NET 5.0)]
    //// 7. Nested Namespace

    // Allowed Access Modifiers inside the Namespace:
    // 1. Internal [Default]
    // 2. Public
    // 3. File [C# 11.0 feature]
    public class TypeA
    {
        /// what you can write inside the class ?
        /// 1. Fields (Attributes | Member variables)
        /// 2. Properties (Full, Automatic)
        /// 3. Indexers (Special property)
        /// 4. Methods
        /// 5. Operators
        /// 6. Constructors
        /// 7. Destructors
        /// 8. Events
        /// 9. Static members (Static fields, static properties,static methods,static constructor)
        /// 10. Nested Types (Classes, structs,interfaces,enums and etc...)

        /// Allowed Access modifiers inside the Class:
        /// 1. Private
        /// 2. Private Protected
        /// 3. Protected
        /// 4. internal
        /// 5. internal protected
        /// 6. public
    }

    public struct TypeZ
    {
        /// what you can write inside the struct ?
        /// 1. Fields (Attributes | Member variables)
        /// 2. Properties (Full, Automatic)
        /// 3. Indexers (Special property)
        /// 4. Methods
        /// 5. Operators
        /// 6. Constructors
        /// 7. Events
        /// 8. Nested Types (Classes, structs,interfaces,enums and etc...)

        /// Allowed Access modifiers inside the enum:
        /// 1. Private
        /// 2. internal
        /// 3. public
    }

    public interface IBehaviour
    {
        /// What you can write inside the interface?
        /// 1. Signature Methods
        /// 2. Signature Properties
        /// 3. Default implemented Method [C# 8.0 New feature (.NET Core 3.1)]
        /// 4. Static Members [C# 8.0 New feature (.NET Core 3.1)]
        ///    - Static Method
        ///    - Static property
        ///    - Static Fields [Constants]
        ///    - Static Events


        /// Allowed Access modifiers inside the Interface:
        /// 1. Private Protected
        /// 2. Protected
        /// 3. internal
        /// 4. internal protected
        /// 5. public


        // Default Access modifier inside the interface : Public


    }

    public enum Gender : byte
    {
        Male = 100,Female= 200
    }

    public delegate string Func(int Number);
}
