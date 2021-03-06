/* Ben Scott * bescott@andrew.cmu.edu * 2016-02-09 * Sudoku */

using UnityEngine;
using System.Collections.Generic;


public static class EnumUtil {
	public static IEnumerable<T> GetValues<T>() {
		return System.Enum.GetValues(typeof(T)) as IEnumerable<T>;
	}
}

public enum Tiles : int {
	Default=0,
	Raise=1,
	Lower=2,
	Level=3,
	Spout=4,
	Empty=5,
	Rock=6}


public enum Dir : int {
	North=0,
	East=90,
	South=180,
	West=270}
