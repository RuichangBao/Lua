print("HotFix Start")
require 'Utils.LuaGlobal'

for key, v in pairs(package.loaded) do
    print(key,v)
end
package.loaded['Utils.LuaGlobal'] = nil
LuaGlobal = require("Utils.LuaGlobal")

print("HotFix End")