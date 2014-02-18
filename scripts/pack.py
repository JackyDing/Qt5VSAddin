from subprocess import Popen, STDOUT, PIPE
import os
import glob
import _winreg

for x in glob.glob('*.log'):
    os.unlink(x)

class MbException(Exception):
    def __init__(self, msg, exit_code = None):
        super(MbException, self).__init__(msg)
        self.exit_code = exit_code

class Mb(object):
    def __init__(self, solution = None, version = None):
        self.solution = solution
        try:
            key = _winreg.OpenKey(_winreg.HKEY_LOCAL_MACHINE, r"SOFTWARE\Microsoft\MSBuild\ToolsVersions\%s" % version)
            self.msbuild = _winreg.QueryValueEx(key, "MSBuildToolsPath")[0] + "msbuild.exe"
        except WindowsError, ex:
            self.msbuild = "msbuild.exe"

    def command(self, *args):
        proc = Popen([self.msbuild, self.solution] + list(args), stdout = PIPE, stderr = PIPE)
        out, err = proc.communicate()
        if proc.returncode:
            cmd = (" ".join([self.msbuild, self.solution] + list(args)))
            raise MbException("Error running<%d>: %s\n\t%s" % (proc.returncode, cmd, err), proc.returncode)
        return out
        
    def clean(self, config = None):
        if config:
            self.command('/t:Clean', '/p:Configuration=' + config)
        else:
            self.command('/t:Clean')

    def build(self, config = None, log = None):
        if config:
            self.command('/t:Rebuild', '/p:Configuration=' + config, '/flp2:errorsonly;LogFile=%s;Encoding=UTF-8' % log)
        else:
            self.command('/t:Rebuild')
    

Qt5VSAddin2010 = Mb(os.path.realpath("..\\src\\Qt5VSAddin2010.sln"), 12.0)
Qt5VSAddin2010.clean('Release')
Qt5VSAddin2010.build("Release", "Qt5VSAddin2010.log")

Qt5VSAddin2012 = Mb(os.path.realpath("..\\src\\Qt5VSAddin2012.sln"), 12.0)
Qt5VSAddin2012.clean('Release')
Qt5VSAddin2012.build("Release", "Qt5VSAddin2012.log")

Qt5VSAddin2013 = Mb(os.path.realpath("..\\src\\Qt5VSAddin2013.sln"), 12.0)
Qt5VSAddin2013.clean('Release')
Qt5VSAddin2013.build("Release", "Qt5VSAddin2013.log")

Qt5VSAddin = Mb(os.path.realpath("..\\pkg\\Qt5VSAddin2010.sln"), 12.0)
Qt5VSAddin.build("Release", "Qt5VSAddin.log")
