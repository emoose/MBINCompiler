using System;
using System.Threading.Tasks;

namespace libMBIN.Common {

    internal class Async {

        /// <summary>
        /// Perform an action that can only be executed in one task at a time.
        /// Other tasks must wait before they can perform the same action.
        /// </summary>
        /// <param name="lockVar">Each unique action requires a unique lockVar. The lockVar must not be null and should never change. Changing the value of the lockVar breaks the lock.</param>
        /// <param name="taskVar">Each unique action requires a unique taskVar. Do not modify the taskVar. It is used to synchronize multiple instances of action.</param>
        /// <param name="action">The action to be synchronized.</param>
        public static void SynchronizeTask( object lockVar, ref Task taskVar, Action action ) {
            // multiples tasks can execute simultaneously on the same thread or on different threads
            // so we have to handle both situations
            lock ( lockVar ) { // block other tasks on other threads
                taskVar?.Wait(); // block other tasks on the same thread
                taskVar = Task.Factory.StartNew( action ); // do it
                taskVar?.Wait(); // wait for completion
                taskVar = null; // unblock other tasks
            } // unblock other threads
        }

    }

}
