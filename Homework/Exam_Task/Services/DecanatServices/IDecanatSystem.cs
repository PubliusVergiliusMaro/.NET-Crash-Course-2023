﻿using Exam_Task.Database.Entities;
using Exam_Task.Services.GroupServices;
using Exam_Task.Services.LecturerServices;
using Exam_Task.Services.StudentServices;
using Exam_Task.Services.SubjectServices;

namespace Exam_Task.Services.DecanatServices
{
	public interface IDecanatSystem
	{
		Task GiveMark();
		Task ShowStudentsSubject();
		Task Show();
		Task Delete();
		Task Add();
	}
}
