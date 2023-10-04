using System;
using UnityEngine;

public class Conductor
{
	[SerializeField] private static double _currentBPS;   // Assigned beats-per-second
	[SerializeField] private static double _currentBPM; // Assigned beats-per-minute

	[SerializeField] private static double _inputOffset = 0.0; // The offset between a keypress and being processed by the program, in seconds

	[SerializeField] private static double _realStartedTime = 0.0;
	[SerializeField] private static double _startedTime = 0.0;

	public static double RealStartedTime
	{
		get => _realStartedTime;
	}

	public static double StartedTime
	{
		get => _startedTime;
	}

	// Raw values are relative to the true time since the start of a song
	// These values should be used for anything that is not affected by
	// input delay, such as graphics and sound effects
	public static double RawSongTime
	{
		get => (AudioSettings.dspTime - _startedTime);
	}
	public static float RawSongBeat
	{
		get => (float)(RawSongTime * _currentBPS);
	}
	public static int RawLastBeat
	{
		get => Mathf.FloorToInt(RawSongBeat);
	}
	public static int RawNearestBeat
	{
		get => Mathf.RoundToInt(RawSongBeat);
	}
	public static float RawBeatDelta
	{
		get => (RawSongBeat - RawNearestBeat) / (float)_currentBPS;
	}

	// These values are relative to the time since the start of a song
	// with input delay removed. They should be used whenever input is
	// being checked, such as deciding whether to attack or take damage.
	public static double SongTime
	{
		get => (AudioSettings.dspTime - _startedTime - _inputOffset); // The current position in the song in seconds
	}
	public static float SongBeat
	{
		get => (float)(SongTime * _currentBPS); // The current position in beats, can be between beats
	}
	public static int LastBeat
	{
		get => Mathf.FloorToInt(SongBeat); // The number of the last beat, starting at 0 at the start of the song
	}
	public static int NearestBeat
	{
		get => Mathf.RoundToInt(SongBeat); // The number of the closest beat, starting at 0 at the start of the song
	}
	public static float BeatDelta
	{
		get => (SongBeat - NearestBeat) / (float)_currentBPS; // Offset of the closest beat in seconds
	}

	public static double InputOffset
	{
		get => _inputOffset; set => _inputOffset = value;
	}

	// Beats per second
	public static double CurrentBPS
	{
		get => _currentBPS;
		private set
		{
			_currentBPS = value;
			_currentBPM = value * 60.0;
		}
	}

	// Beats per minute
	public static double CurrentBPM
	{
		get => _currentBPM;
		private set {
			_currentBPM = value;
			_currentBPS = value / 60.0;
		}
	}

	// Seconds per beat
	public static float SecondsPerBeat
	{
		get => 1.0f / (float)_currentBPS;
	}

	// Sets the reference point for beats and time to be calculated relative to
	public static void StartTracking(double bpm, double start, double startOffset)
	{
		CurrentBPM = bpm;
		_realStartedTime = start;
		_startedTime = start + startOffset;
	}
}
