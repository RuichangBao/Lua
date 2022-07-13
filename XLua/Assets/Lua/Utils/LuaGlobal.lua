print(" LuaGlobal")

LuaGlobal={
    a=200,
}

--[[local __g = _G
LuaGlobal.exports = {}
setmetatable(LuaGlobal.exports, {
    __newindex = function(_, name, value)
        rawset(__g, name, value)
    end,
    __index = function(_, name)
        return rawget(__g, name)
    end
})

-- 禁用创建意外全局变量
setmetatable(__g, {
    __newindex = function(_, name, value)
        local msg = "使用全局变量 %s 错误"
        error(string.format(msg, name))
    end
})--]]

return LuaGlobal