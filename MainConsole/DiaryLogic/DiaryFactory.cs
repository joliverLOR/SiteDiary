using System;
using System.Net;
using DBConnect;


namespace DailyDiary;

public class DiaryFactory
{
    public static DiaryEntry Create(DiaryMethod diaryType, int id)
    {
        switch(diaryType)
        {
            case DiaryMethod.MajorConstructionDiary:
                return DiaryOptions.MajorDiaryOption(id);
            case DiaryMethod.Discussions:
                return DiaryOptions.DiscussionOption(id);
            default:
                throw new NotSupportedException(
                    $"Not supported type {diaryType}"
                );
        }
    }
}
