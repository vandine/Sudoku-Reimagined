/* Ben Scott * bescott@andrew.cmu.edu * 2016-02-03 * ISpace */

using UnityEngine;
using System.Collections.Generic;


/** `ISpace<T>` : **`interface`**
 *
 * A generic wrapper for values to be stored in an instance of
 * an `ISudokuBoard<T>`.
 *
 * - `T` : **`type`**
 *     type to be stored at this space
 *
 **/
public interface ISpace<T> {


	/** `Value` : **`<T>`**
	 *
	 * A value of the underlying type to be put in this space.
	 **/
    T Value {get;set;}


    /** `Direction` : **`Dir`**
     *
     * This tile's current Y rotation.
     **/
	Dir Direction {get;set;}


    /** `HasWater` : **`bool`**
     *
     * Denotes the presence of water on this tile.
     **/
	bool HasWater {get;set;}


    /** `IsEmpty` : **`bool`**
     *
     * Checks against `Value` to determine if something can be
     * put in this slot.
     **/
    bool IsEmpty {get;}
}
