using System;
using System.Diagnostics.CodeAnalysis;

namespace Pragma.Core
{
    public enum Lifecircle
    {
        InResolutionScope,
        InThread,
        InWebRequest,
        Singleton,
        Transient
    }

    /// <summary>
    /// Tipos de controles utilizados nas grades
    /// </summary>
    public enum ControlType
    {
        TextBox,
        TextBoxEdit,
        CheckBox,
        ComboBox
    }

    /// <summary>
    /// Nível de Severidade do ValidationFailure
    /// </summary>
    public enum FailureSeverity
    {

        Info = 1,
        Warning = 2,
        Error = 3
    }

    public enum BalloonIcon
    {
        NONE,
        INFO,
        WARNING,
        ERROR
    }


    // Summary:
    //     Describes the state of an entity.
    [Flags]
    [SuppressMessage("Microsoft.Naming", "CA1714:FlagsEnumsShouldHavePluralNames")]
    public enum ModelState
    {
        //
        // Summary:
        //     The entity is not being tracked by the context. An entity is in this state immediately
        //     after it has been created with the new operator or with one of the System.Data.Entity.DbSet
        //     Create methods.
        Detached = 1,
        //
        // Summary:
        //     The entity is being tracked by the context and exists in the database, and its
        //     property values have not changed from the values in the database.
        Unchanged = 2,
        //
        // Summary:
        //     The entity is being tracked by the context but does not yet exist in the database.
        Added = 4,
        //
        // Summary:
        //     The entity is being tracked by the context and exists in the database, but has
        //     been marked for deletion from the database the next time SaveChanges is called.
        Deleted = 8,
        //
        // Summary:
        //     The entity is being tracked by the context and exists in the database, and some
        //     or all of its property values have been modified.
        Modified = 16
    }

}
