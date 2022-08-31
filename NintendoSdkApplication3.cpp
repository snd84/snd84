
#include <nn/nn_Assert.h>
#include <nn/nn_Log.h>
#include <nn/TargetConfigs/build_Base.h>
#include <nn/oe.h>
#include <nn/os.h>
#include <nn/hid.h>
#include <GL/glew.h>
#include "GraphicsHelper.h"
#include "Windows.h"
#include "Inputkeyboard.h"
#include <Vector>
#include <iostream>

namespace
{
	const char* VertexShaderSource =
		"#version 320 es\n"
		"precision highp float;\n"
		"layout( location = 0) in vec4 a_Position;\n"
		"void main() {\n"
		"    gl_Position = a_Position;\n"
		"}\n";

	const char* FragmentShaderSource =
		"#version 320 es\n"
		"precision highp float;\n"
		"layout( location = 0 ) out vec4 o_Color;\n"
		"void main() {\n"
		"    o_Color = vec4(0.0, 1.0, 0.0, 1.0);\n"
		"}\n";

	GraphicsHelper s_GraphicsHelper;
	Inputkeyboard currentKey;

	GLuint s_PosLocation;
	GLuint s_TimeLocation;

	GLuint s_VertexShaderId;
	GLuint s_FragmentShaderId;
	GLuint s_ShaderProgramId;
	GLuint s_VertexBufferId;
	GLuint s_VaoId;
	GLuint s_Call = GL_TRIANGLES;
	int CallNum = 0;
	std::vector<GLfloat> VERTEX_DATA{-0.9,-0.9, -0.8,-0.9, -0.85,-0.80};

} // namespace


void InitializeGraphics()
{
	s_GraphicsHelper.Initialize();

}

void InitializeShaders()
{
	s_VertexShaderId = glCreateShader(GL_VERTEX_SHADER);
	glShaderSource(s_VertexShaderId, 1, &VertexShaderSource, 0);
	glCompileShader(s_VertexShaderId);

	s_FragmentShaderId = glCreateShader(GL_FRAGMENT_SHADER);
	glShaderSource(s_FragmentShaderId, 1, &FragmentShaderSource, 0);
	glCompileShader(s_FragmentShaderId);


	s_ShaderProgramId = glCreateProgram();

	glAttachShader(s_ShaderProgramId, s_VertexShaderId);
	glAttachShader(s_ShaderProgramId, s_FragmentShaderId);
	glLinkProgram(s_ShaderProgramId);
	glUseProgram(s_ShaderProgramId);

	s_PosLocation = glGetAttribLocation(s_ShaderProgramId, "a_Position");
	s_TimeLocation = glGetUniformLocation(s_ShaderProgramId, "u_time");
}

void InitializeVertexData()
{
	glGenVertexArrays(1, &s_VaoId);
	glBindVertexArray(s_VaoId);
	glGenBuffers(1, &s_VertexBufferId);
	glBindBuffer(GL_ARRAY_BUFFER, s_VertexBufferId);
	glBufferData(GL_ARRAY_BUFFER, sizeof(VERTEX_DATA) * VERTEX_DATA.size(), std::data(VERTEX_DATA), GL_STATIC_DRAW);
	glEnableVertexAttribArray(s_PosLocation);
	glVertexAttribPointer(s_PosLocation, 2, GL_FLOAT, GL_FALSE, 0, 0);
	glBindBuffer(GL_ARRAY_BUFFER, 0);
	glBindVertexArray(0);
}

void SetupScene()
{
	glClearColor(1.0f, 1.0f, 1.0f, 1.0f);
}

void RenderScene(float time)
{
	glClear(GL_COLOR_BUFFER_BIT);

	glUseProgram(s_ShaderProgramId);

	glUniform1f(s_TimeLocation, time);
	glBindVertexArray(s_VaoId);

	glDrawArrays(s_Call, 0,VERTEX_DATA.size());
	glBindVertexArray(0);

	glUseProgram(0);
}

void SwapBuffers()
{
	s_GraphicsHelper.SwapBuffers();
}

void Destroy()
{
	glDetachShader(s_ShaderProgramId, s_VertexShaderId);
	glDetachShader(s_ShaderProgramId, s_FragmentShaderId);

	glDeleteShader(s_VertexShaderId);
	glDeleteShader(s_FragmentShaderId);

	glDeleteProgram(s_ShaderProgramId);

	glDeleteBuffers(1, &s_VertexBufferId);
	glDeleteVertexArrays(1, &s_VaoId);
}

void FinalizeGraphics()
{
	s_GraphicsHelper.Finalize();
}

void addVertex()
{
	int x = (int)(VERTEX_DATA.size() / 6);
	VERTEX_DATA.push_back(VERTEX_DATA[0] + (GLfloat)0.05 * x);
	VERTEX_DATA.push_back(VERTEX_DATA[1] + (GLfloat)0.05 * x);
	VERTEX_DATA.push_back(VERTEX_DATA[2] + (GLfloat)0.05 * x);
	VERTEX_DATA.push_back(VERTEX_DATA[3] + (GLfloat)0.05 * x);
	VERTEX_DATA.push_back(VERTEX_DATA[4] + (GLfloat)0.05 * x);
	VERTEX_DATA.push_back(VERTEX_DATA[5] + (GLfloat)0.05 * x);

	InitializeVertexData();
}
void glDrawShaderCall(int i) {
	CallNum += i;
	CallNum = CallNum > 4 ? 0 : CallNum;
	CallNum = CallNum < 0 ? 4 : CallNum;

	switch (i) {
	case 0:	s_Call = GL_TRIANGLES; break;
	case 1:	s_Call = GL_TRIANGLE_FAN; break;
	case 2:	s_Call = GL_LINES; break;
	case 3:	s_Call = GL_LINE_STRIP; break;
	case 4:	s_Call = GL_TRIANGLE_STRIP; break;
	}
}
void subtractionVertex()
{
	if (VERTEX_DATA.size() > 6){
		
		VERTEX_DATA.resize(VERTEX_DATA.size()-6);


		Destroy();
		InitializeShaders();
		InitializeVertexData();
	}
}
extern "C" void nnMain()
{
	InitializeGraphics();
	InitializeShaders();
	InitializeVertexData();
	SetupScene();

	nn::os::Tick frameTime(nn::TimeSpan::FromMilliSeconds(0));
	nn::os::Tick frameTimePrev = nn::os::GetSystemTick();

	int64_t currTime = 0;

	bool LoopSwitch = true;

	while (LoopSwitch)
	{
		frameTime = nn::os::GetSystemTick();
		int64_t frameDiff = frameTime.ToTimeSpan().GetMilliSeconds() - frameTimePrev.ToTimeSpan().GetMilliSeconds();
		currTime += frameDiff;

		RenderScene(static_cast<float>(currTime) * 0.0005f);
		SwapBuffers();

		frameTimePrev = frameTime;
		currentKey.KeyCheck();
		if (currentKey.GetKeyInput_On(0) == 3) {
			LoopSwitch = false;
		}
		if (currentKey.GetKeyInput_On(2) == 1) {
			addVertex();
		}
		if (currentKey.GetKeyInput_On(1) == 1) {
			subtractionVertex();
		}
		if (currentKey.GetKeyInput_On(3) == 1) {
			glDrawShaderCall(1);
		}
		if (currentKey.GetKeyInput_On(4) == 1) {
			glDrawShaderCall(-1);
		}


	};

	Destroy();
	FinalizeGraphics();

	return;
}
