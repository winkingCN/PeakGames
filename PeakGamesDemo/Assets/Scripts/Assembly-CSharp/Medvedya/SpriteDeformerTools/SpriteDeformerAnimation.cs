using System;
using System.Collections.Generic;
using UnityEngine;

namespace Medvedya.SpriteDeformerTools
{
	[ExecuteInEditMode]
	[AddComponentMenu("Sprite Deformer/Sprite deformer Animation")]
	public class SpriteDeformerAnimation : SpriteDeformerWithMaterialPropertyBlock, ISerializationCallbackReceiver
	{
		[Serializable]
		public struct PointInfo
		{
			public Color color;

			public Vector3 offset;

			public Vector2 position;
		}

		public List<SpritePoint> notAnimatedPoints = new List<SpritePoint>();

		[SerializeField]
		private bool[] busyPoints = new bool[256];

		[SerializeField]
		public SpritePoint[] animationPoints = new SpritePoint[256];

		[SerializeField]
		private int[] serelizateAnimationPoints = new int[256];

		[SerializeField]
		private PointInfo v000 = default(PointInfo);

		[SerializeField]
		private PointInfo v001 = default(PointInfo);

		[SerializeField]
		private PointInfo v002 = default(PointInfo);

		[SerializeField]
		private PointInfo v003 = default(PointInfo);

		[SerializeField]
		private PointInfo v004 = default(PointInfo);

		[SerializeField]
		private PointInfo v005 = default(PointInfo);

		[SerializeField]
		private PointInfo v006 = default(PointInfo);

		[SerializeField]
		private PointInfo v007 = default(PointInfo);

		[SerializeField]
		private PointInfo v008 = default(PointInfo);

		[SerializeField]
		private PointInfo v009 = default(PointInfo);

		[SerializeField]
		private PointInfo v010 = default(PointInfo);

		[SerializeField]
		private PointInfo v011 = default(PointInfo);

		[SerializeField]
		private PointInfo v012 = default(PointInfo);

		[SerializeField]
		private PointInfo v013 = default(PointInfo);

		[SerializeField]
		private PointInfo v014 = default(PointInfo);

		[SerializeField]
		private PointInfo v015 = default(PointInfo);

		[SerializeField]
		private PointInfo v016 = default(PointInfo);

		[SerializeField]
		private PointInfo v017 = default(PointInfo);

		[SerializeField]
		private PointInfo v018 = default(PointInfo);

		[SerializeField]
		private PointInfo v019 = default(PointInfo);

		[SerializeField]
		private PointInfo v020 = default(PointInfo);

		[SerializeField]
		private PointInfo v021 = default(PointInfo);

		[SerializeField]
		private PointInfo v022 = default(PointInfo);

		[SerializeField]
		private PointInfo v023 = default(PointInfo);

		[SerializeField]
		private PointInfo v024 = default(PointInfo);

		[SerializeField]
		private PointInfo v025 = default(PointInfo);

		[SerializeField]
		private PointInfo v026 = default(PointInfo);

		[SerializeField]
		private PointInfo v027 = default(PointInfo);

		[SerializeField]
		private PointInfo v028 = default(PointInfo);

		[SerializeField]
		private PointInfo v029 = default(PointInfo);

		[SerializeField]
		private PointInfo v030 = default(PointInfo);

		[SerializeField]
		private PointInfo v031 = default(PointInfo);

		[SerializeField]
		private PointInfo v032 = default(PointInfo);

		[SerializeField]
		private PointInfo v033 = default(PointInfo);

		[SerializeField]
		private PointInfo v034 = default(PointInfo);

		[SerializeField]
		private PointInfo v035 = default(PointInfo);

		[SerializeField]
		private PointInfo v036 = default(PointInfo);

		[SerializeField]
		private PointInfo v037 = default(PointInfo);

		[SerializeField]
		private PointInfo v038 = default(PointInfo);

		[SerializeField]
		private PointInfo v039 = default(PointInfo);

		[SerializeField]
		private PointInfo v040 = default(PointInfo);

		[SerializeField]
		private PointInfo v041 = default(PointInfo);

		[SerializeField]
		private PointInfo v042 = default(PointInfo);

		[SerializeField]
		private PointInfo v043 = default(PointInfo);

		[SerializeField]
		private PointInfo v044 = default(PointInfo);

		[SerializeField]
		private PointInfo v045 = default(PointInfo);

		[SerializeField]
		private PointInfo v046 = default(PointInfo);

		[SerializeField]
		private PointInfo v047 = default(PointInfo);

		[SerializeField]
		private PointInfo v048 = default(PointInfo);

		[SerializeField]
		private PointInfo v049 = default(PointInfo);

		[SerializeField]
		private PointInfo v050 = default(PointInfo);

		[SerializeField]
		private PointInfo v051 = default(PointInfo);

		[SerializeField]
		private PointInfo v052 = default(PointInfo);

		[SerializeField]
		private PointInfo v053 = default(PointInfo);

		[SerializeField]
		private PointInfo v054 = default(PointInfo);

		[SerializeField]
		private PointInfo v055 = default(PointInfo);

		[SerializeField]
		private PointInfo v056 = default(PointInfo);

		[SerializeField]
		private PointInfo v057 = default(PointInfo);

		[SerializeField]
		private PointInfo v058 = default(PointInfo);

		[SerializeField]
		private PointInfo v059 = default(PointInfo);

		[SerializeField]
		private PointInfo v060 = default(PointInfo);

		[SerializeField]
		private PointInfo v061 = default(PointInfo);

		[SerializeField]
		private PointInfo v062 = default(PointInfo);

		[SerializeField]
		private PointInfo v063 = default(PointInfo);

		[SerializeField]
		private PointInfo v064 = default(PointInfo);

		[SerializeField]
		private PointInfo v065 = default(PointInfo);

		[SerializeField]
		private PointInfo v066 = default(PointInfo);

		[SerializeField]
		private PointInfo v067 = default(PointInfo);

		[SerializeField]
		private PointInfo v068 = default(PointInfo);

		[SerializeField]
		private PointInfo v069 = default(PointInfo);

		[SerializeField]
		private PointInfo v070 = default(PointInfo);

		[SerializeField]
		private PointInfo v071 = default(PointInfo);

		[SerializeField]
		private PointInfo v072 = default(PointInfo);

		[SerializeField]
		private PointInfo v073 = default(PointInfo);

		[SerializeField]
		private PointInfo v074 = default(PointInfo);

		[SerializeField]
		private PointInfo v075 = default(PointInfo);

		[SerializeField]
		private PointInfo v076 = default(PointInfo);

		[SerializeField]
		private PointInfo v077 = default(PointInfo);

		[SerializeField]
		private PointInfo v078 = default(PointInfo);

		[SerializeField]
		private PointInfo v079 = default(PointInfo);

		[SerializeField]
		private PointInfo v080 = default(PointInfo);

		[SerializeField]
		private PointInfo v081 = default(PointInfo);

		[SerializeField]
		private PointInfo v082 = default(PointInfo);

		[SerializeField]
		private PointInfo v083 = default(PointInfo);

		[SerializeField]
		private PointInfo v084 = default(PointInfo);

		[SerializeField]
		private PointInfo v085 = default(PointInfo);

		[SerializeField]
		private PointInfo v086 = default(PointInfo);

		[SerializeField]
		private PointInfo v087 = default(PointInfo);

		[SerializeField]
		private PointInfo v088 = default(PointInfo);

		[SerializeField]
		private PointInfo v089 = default(PointInfo);

		[SerializeField]
		private PointInfo v090 = default(PointInfo);

		[SerializeField]
		private PointInfo v091 = default(PointInfo);

		[SerializeField]
		private PointInfo v092 = default(PointInfo);

		[SerializeField]
		private PointInfo v093 = default(PointInfo);

		[SerializeField]
		private PointInfo v094 = default(PointInfo);

		[SerializeField]
		private PointInfo v095 = default(PointInfo);

		[SerializeField]
		private PointInfo v096 = default(PointInfo);

		[SerializeField]
		private PointInfo v097 = default(PointInfo);

		[SerializeField]
		private PointInfo v098 = default(PointInfo);

		[SerializeField]
		private PointInfo v099 = default(PointInfo);

		[SerializeField]
		private PointInfo v100 = default(PointInfo);

		[SerializeField]
		private PointInfo v101 = default(PointInfo);

		[SerializeField]
		private PointInfo v102 = default(PointInfo);

		[SerializeField]
		private PointInfo v103 = default(PointInfo);

		[SerializeField]
		private PointInfo v104 = default(PointInfo);

		[SerializeField]
		private PointInfo v105 = default(PointInfo);

		[SerializeField]
		private PointInfo v106 = default(PointInfo);

		[SerializeField]
		private PointInfo v107 = default(PointInfo);

		[SerializeField]
		private PointInfo v108 = default(PointInfo);

		[SerializeField]
		private PointInfo v109 = default(PointInfo);

		[SerializeField]
		private PointInfo v110 = default(PointInfo);

		[SerializeField]
		private PointInfo v111 = default(PointInfo);

		[SerializeField]
		private PointInfo v112 = default(PointInfo);

		[SerializeField]
		private PointInfo v113 = default(PointInfo);

		[SerializeField]
		private PointInfo v114 = default(PointInfo);

		[SerializeField]
		private PointInfo v115 = default(PointInfo);

		[SerializeField]
		private PointInfo v116 = default(PointInfo);

		[SerializeField]
		private PointInfo v117 = default(PointInfo);

		[SerializeField]
		private PointInfo v118 = default(PointInfo);

		[SerializeField]
		private PointInfo v119 = default(PointInfo);

		[SerializeField]
		private PointInfo v120 = default(PointInfo);

		[SerializeField]
		private PointInfo v121 = default(PointInfo);

		[SerializeField]
		private PointInfo v122 = default(PointInfo);

		[SerializeField]
		private PointInfo v123 = default(PointInfo);

		[SerializeField]
		private PointInfo v124 = default(PointInfo);

		[SerializeField]
		private PointInfo v125 = default(PointInfo);

		[SerializeField]
		private PointInfo v126 = default(PointInfo);

		[SerializeField]
		private PointInfo v127 = default(PointInfo);

		[SerializeField]
		private PointInfo v128 = default(PointInfo);

		[SerializeField]
		private PointInfo v129 = default(PointInfo);

		[SerializeField]
		private PointInfo v130 = default(PointInfo);

		[SerializeField]
		private PointInfo v131 = default(PointInfo);

		[SerializeField]
		private PointInfo v132 = default(PointInfo);

		[SerializeField]
		private PointInfo v133 = default(PointInfo);

		[SerializeField]
		private PointInfo v134 = default(PointInfo);

		[SerializeField]
		private PointInfo v135 = default(PointInfo);

		[SerializeField]
		private PointInfo v136 = default(PointInfo);

		[SerializeField]
		private PointInfo v137 = default(PointInfo);

		[SerializeField]
		private PointInfo v138 = default(PointInfo);

		[SerializeField]
		private PointInfo v139 = default(PointInfo);

		[SerializeField]
		private PointInfo v140 = default(PointInfo);

		[SerializeField]
		private PointInfo v141 = default(PointInfo);

		[SerializeField]
		private PointInfo v142 = default(PointInfo);

		[SerializeField]
		private PointInfo v143 = default(PointInfo);

		[SerializeField]
		private PointInfo v144 = default(PointInfo);

		[SerializeField]
		private PointInfo v145 = default(PointInfo);

		[SerializeField]
		private PointInfo v146 = default(PointInfo);

		[SerializeField]
		private PointInfo v147 = default(PointInfo);

		[SerializeField]
		private PointInfo v148 = default(PointInfo);

		[SerializeField]
		private PointInfo v149 = default(PointInfo);

		[SerializeField]
		private PointInfo v150 = default(PointInfo);

		[SerializeField]
		private PointInfo v151 = default(PointInfo);

		[SerializeField]
		private PointInfo v152 = default(PointInfo);

		[SerializeField]
		private PointInfo v153 = default(PointInfo);

		[SerializeField]
		private PointInfo v154 = default(PointInfo);

		[SerializeField]
		private PointInfo v155 = default(PointInfo);

		[SerializeField]
		private PointInfo v156 = default(PointInfo);

		[SerializeField]
		private PointInfo v157 = default(PointInfo);

		[SerializeField]
		private PointInfo v158 = default(PointInfo);

		[SerializeField]
		private PointInfo v159 = default(PointInfo);

		[SerializeField]
		private PointInfo v160 = default(PointInfo);

		[SerializeField]
		private PointInfo v161 = default(PointInfo);

		[SerializeField]
		private PointInfo v162 = default(PointInfo);

		[SerializeField]
		private PointInfo v163 = default(PointInfo);

		[SerializeField]
		private PointInfo v164 = default(PointInfo);

		[SerializeField]
		private PointInfo v165 = default(PointInfo);

		[SerializeField]
		private PointInfo v166 = default(PointInfo);

		[SerializeField]
		private PointInfo v167 = default(PointInfo);

		[SerializeField]
		private PointInfo v168 = default(PointInfo);

		[SerializeField]
		private PointInfo v169 = default(PointInfo);

		[SerializeField]
		private PointInfo v170 = default(PointInfo);

		[SerializeField]
		private PointInfo v171 = default(PointInfo);

		[SerializeField]
		private PointInfo v172 = default(PointInfo);

		[SerializeField]
		private PointInfo v173 = default(PointInfo);

		[SerializeField]
		private PointInfo v174 = default(PointInfo);

		[SerializeField]
		private PointInfo v175 = default(PointInfo);

		[SerializeField]
		private PointInfo v176 = default(PointInfo);

		[SerializeField]
		private PointInfo v177 = default(PointInfo);

		[SerializeField]
		private PointInfo v178 = default(PointInfo);

		[SerializeField]
		private PointInfo v179 = default(PointInfo);

		[SerializeField]
		private PointInfo v180 = default(PointInfo);

		[SerializeField]
		private PointInfo v181 = default(PointInfo);

		[SerializeField]
		private PointInfo v182 = default(PointInfo);

		[SerializeField]
		private PointInfo v183 = default(PointInfo);

		[SerializeField]
		private PointInfo v184 = default(PointInfo);

		[SerializeField]
		private PointInfo v185 = default(PointInfo);

		[SerializeField]
		private PointInfo v186 = default(PointInfo);

		[SerializeField]
		private PointInfo v187 = default(PointInfo);

		[SerializeField]
		private PointInfo v188 = default(PointInfo);

		[SerializeField]
		private PointInfo v189 = default(PointInfo);

		[SerializeField]
		private PointInfo v190 = default(PointInfo);

		[SerializeField]
		private PointInfo v191 = default(PointInfo);

		[SerializeField]
		private PointInfo v192 = default(PointInfo);

		[SerializeField]
		private PointInfo v193 = default(PointInfo);

		[SerializeField]
		private PointInfo v194 = default(PointInfo);

		[SerializeField]
		private PointInfo v195 = default(PointInfo);

		[SerializeField]
		private PointInfo v196 = default(PointInfo);

		[SerializeField]
		private PointInfo v197 = default(PointInfo);

		[SerializeField]
		private PointInfo v198 = default(PointInfo);

		[SerializeField]
		private PointInfo v199 = default(PointInfo);

		[SerializeField]
		private PointInfo v200 = default(PointInfo);

		[SerializeField]
		private PointInfo v201 = default(PointInfo);

		[SerializeField]
		private PointInfo v202 = default(PointInfo);

		[SerializeField]
		private PointInfo v203 = default(PointInfo);

		[SerializeField]
		private PointInfo v204 = default(PointInfo);

		[SerializeField]
		private PointInfo v205 = default(PointInfo);

		[SerializeField]
		private PointInfo v206 = default(PointInfo);

		[SerializeField]
		private PointInfo v207 = default(PointInfo);

		[SerializeField]
		private PointInfo v208 = default(PointInfo);

		[SerializeField]
		private PointInfo v209 = default(PointInfo);

		[SerializeField]
		private PointInfo v210 = default(PointInfo);

		[SerializeField]
		private PointInfo v211 = default(PointInfo);

		[SerializeField]
		private PointInfo v212 = default(PointInfo);

		[SerializeField]
		private PointInfo v213 = default(PointInfo);

		[SerializeField]
		private PointInfo v214 = default(PointInfo);

		[SerializeField]
		private PointInfo v215 = default(PointInfo);

		[SerializeField]
		private PointInfo v216 = default(PointInfo);

		[SerializeField]
		private PointInfo v217 = default(PointInfo);

		[SerializeField]
		private PointInfo v218 = default(PointInfo);

		[SerializeField]
		private PointInfo v219 = default(PointInfo);

		[SerializeField]
		private PointInfo v220 = default(PointInfo);

		[SerializeField]
		private PointInfo v221 = default(PointInfo);

		[SerializeField]
		private PointInfo v222 = default(PointInfo);

		[SerializeField]
		private PointInfo v223 = default(PointInfo);

		[SerializeField]
		private PointInfo v224 = default(PointInfo);

		[SerializeField]
		private PointInfo v225 = default(PointInfo);

		[SerializeField]
		private PointInfo v226 = default(PointInfo);

		[SerializeField]
		private PointInfo v227 = default(PointInfo);

		[SerializeField]
		private PointInfo v228 = default(PointInfo);

		[SerializeField]
		private PointInfo v229 = default(PointInfo);

		[SerializeField]
		private PointInfo v230 = default(PointInfo);

		[SerializeField]
		private PointInfo v231 = default(PointInfo);

		[SerializeField]
		private PointInfo v232 = default(PointInfo);

		[SerializeField]
		private PointInfo v233 = default(PointInfo);

		[SerializeField]
		private PointInfo v234 = default(PointInfo);

		[SerializeField]
		private PointInfo v235 = default(PointInfo);

		[SerializeField]
		private PointInfo v236 = default(PointInfo);

		[SerializeField]
		private PointInfo v237 = default(PointInfo);

		[SerializeField]
		private PointInfo v238 = default(PointInfo);

		[SerializeField]
		private PointInfo v239 = default(PointInfo);

		[SerializeField]
		private PointInfo v240 = default(PointInfo);

		[SerializeField]
		private PointInfo v241 = default(PointInfo);

		[SerializeField]
		private PointInfo v242 = default(PointInfo);

		[SerializeField]
		private PointInfo v243 = default(PointInfo);

		[SerializeField]
		private PointInfo v244 = default(PointInfo);

		[SerializeField]
		private PointInfo v245 = default(PointInfo);

		[SerializeField]
		private PointInfo v246 = default(PointInfo);

		[SerializeField]
		private PointInfo v247 = default(PointInfo);

		[SerializeField]
		private PointInfo v248 = default(PointInfo);

		[SerializeField]
		private PointInfo v249 = default(PointInfo);

		[SerializeField]
		private PointInfo v250 = default(PointInfo);

		[SerializeField]
		private PointInfo v251 = default(PointInfo);

		[SerializeField]
		private PointInfo v252 = default(PointInfo);

		[SerializeField]
		private PointInfo v253 = default(PointInfo);

		[SerializeField]
		private PointInfo v254 = default(PointInfo);

		[SerializeField]
		private PointInfo v255 = default(PointInfo);

		public override void AddPoint(SpritePoint KJPPPBMDJKG, bool NJMABEFFHDM = false)
		{
			if (base.JJJGMPMMJIN.Count >= 256)
			{
				Debug.Log("You can't have more any than 256 points");
				return;
			}
			base.AddPoint(KJPPPBMDJKG, NJMABEFFHDM);
			PointInfo eDDNOJDPMCF = default(PointInfo);
			for (int i = 0; i < 256; i++)
			{
				if (!busyPoints[i])
				{
					busyPoints[i] = true;
					animationPoints[i] = KJPPPBMDJKG;
					eDDNOJDPMCF.position = KJPPPBMDJKG.spritePosition;
					eDDNOJDPMCF.color = KJPPPBMDJKG.color;
					eDDNOJDPMCF.offset = KJPPPBMDJKG.offset;
					setValueByIndex(i, eDDNOJDPMCF);
					break;
				}
			}
		}

		public override void RemovePoint(SpritePoint HPHBDNBJPHB)
		{
			int num = -1;
			for (int i = 0; i < 256; i++)
			{
				if (HPHBDNBJPHB == animationPoints[i])
				{
					num = i;
					break;
				}
			}
			if (num != -1)
			{
				busyPoints[num] = false;
			}
			base.RemovePoint(HPHBDNBJPHB);
		}

		protected override void Update()
		{
			if (base.FJOOPODJMFC.isVisible)
			{
				for (int i = 0; i < 256; i++)
				{
					if (busyPoints[i] && !notAnimatedPoints.Contains(animationPoints[i]))
					{
						PointInfo valueByIndex = getValueByIndex(i);
						if (valueByIndex.color != animationPoints[i].color)
						{
							dirty_color = true;
							animationPoints[i].color = valueByIndex.color;
						}
						if (valueByIndex.offset != animationPoints[i].offset)
						{
							dirty_offset = true;
							animationPoints[i].offset = valueByIndex.offset;
						}
					}
				}
			}
			base.Update();
		}

		protected override void Awake()
		{
			base.Awake();
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
		}

		protected override void OnEnable()
		{
			base.OnEnable();
		}

		protected override void OnDisable()
		{
			base.OnDisable();
		}

		public PointInfo getValueByIndex(int PLCFEOMGCFK)
		{
			switch (PLCFEOMGCFK)
			{
			case 0:
				return v000;
			case 1:
				return v001;
			case 2:
				return v002;
			case 3:
				return v003;
			case 4:
				return v004;
			case 5:
				return v005;
			case 6:
				return v006;
			case 7:
				return v007;
			case 8:
				return v008;
			case 9:
				return v009;
			case 10:
				return v010;
			case 11:
				return v011;
			case 12:
				return v012;
			case 13:
				return v013;
			case 14:
				return v014;
			case 15:
				return v015;
			case 16:
				return v016;
			case 17:
				return v017;
			case 18:
				return v018;
			case 19:
				return v019;
			case 20:
				return v020;
			case 21:
				return v021;
			case 22:
				return v022;
			case 23:
				return v023;
			case 24:
				return v024;
			case 25:
				return v025;
			case 26:
				return v026;
			case 27:
				return v027;
			case 28:
				return v028;
			case 29:
				return v029;
			case 30:
				return v030;
			case 31:
				return v031;
			case 32:
				return v032;
			case 33:
				return v033;
			case 34:
				return v034;
			case 35:
				return v035;
			case 36:
				return v036;
			case 37:
				return v037;
			case 38:
				return v038;
			case 39:
				return v039;
			case 40:
				return v040;
			case 41:
				return v041;
			case 42:
				return v042;
			case 43:
				return v043;
			case 44:
				return v044;
			case 45:
				return v045;
			case 46:
				return v046;
			case 47:
				return v047;
			case 48:
				return v048;
			case 49:
				return v049;
			case 50:
				return v050;
			case 51:
				return v051;
			case 52:
				return v052;
			case 53:
				return v053;
			case 54:
				return v054;
			case 55:
				return v055;
			case 56:
				return v056;
			case 57:
				return v057;
			case 58:
				return v058;
			case 59:
				return v059;
			case 60:
				return v060;
			case 61:
				return v061;
			case 62:
				return v062;
			case 63:
				return v063;
			case 64:
				return v064;
			case 65:
				return v065;
			case 66:
				return v066;
			case 67:
				return v067;
			case 68:
				return v068;
			case 69:
				return v069;
			case 70:
				return v070;
			case 71:
				return v071;
			case 72:
				return v072;
			case 73:
				return v073;
			case 74:
				return v074;
			case 75:
				return v075;
			case 76:
				return v076;
			case 77:
				return v077;
			case 78:
				return v078;
			case 79:
				return v079;
			case 80:
				return v080;
			case 81:
				return v081;
			case 82:
				return v082;
			case 83:
				return v083;
			case 84:
				return v084;
			case 85:
				return v085;
			case 86:
				return v086;
			case 87:
				return v087;
			case 88:
				return v088;
			case 89:
				return v089;
			case 90:
				return v090;
			case 91:
				return v091;
			case 92:
				return v092;
			case 93:
				return v093;
			case 94:
				return v094;
			case 95:
				return v095;
			case 96:
				return v096;
			case 97:
				return v097;
			case 98:
				return v098;
			case 99:
				return v099;
			case 100:
				return v100;
			case 101:
				return v101;
			case 102:
				return v102;
			case 103:
				return v103;
			case 104:
				return v104;
			case 105:
				return v105;
			case 106:
				return v106;
			case 107:
				return v107;
			case 108:
				return v108;
			case 109:
				return v109;
			case 110:
				return v110;
			case 111:
				return v111;
			case 112:
				return v112;
			case 113:
				return v113;
			case 114:
				return v114;
			case 115:
				return v115;
			case 116:
				return v116;
			case 117:
				return v117;
			case 118:
				return v118;
			case 119:
				return v119;
			case 120:
				return v120;
			case 121:
				return v121;
			case 122:
				return v122;
			case 123:
				return v123;
			case 124:
				return v124;
			case 125:
				return v125;
			case 126:
				return v126;
			case 127:
				return v127;
			case 128:
				return v128;
			case 129:
				return v129;
			case 130:
				return v130;
			case 131:
				return v131;
			case 132:
				return v132;
			case 133:
				return v133;
			case 134:
				return v134;
			case 135:
				return v135;
			case 136:
				return v136;
			case 137:
				return v137;
			case 138:
				return v138;
			case 139:
				return v139;
			case 140:
				return v140;
			case 141:
				return v141;
			case 142:
				return v142;
			case 143:
				return v143;
			case 144:
				return v144;
			case 145:
				return v145;
			case 146:
				return v146;
			case 147:
				return v147;
			case 148:
				return v148;
			case 149:
				return v149;
			case 150:
				return v150;
			case 151:
				return v151;
			case 152:
				return v152;
			case 153:
				return v153;
			case 154:
				return v154;
			case 155:
				return v155;
			case 156:
				return v156;
			case 157:
				return v157;
			case 158:
				return v158;
			case 159:
				return v159;
			case 160:
				return v160;
			case 161:
				return v161;
			case 162:
				return v162;
			case 163:
				return v163;
			case 164:
				return v164;
			case 165:
				return v165;
			case 166:
				return v166;
			case 167:
				return v167;
			case 168:
				return v168;
			case 169:
				return v169;
			case 170:
				return v170;
			case 171:
				return v171;
			case 172:
				return v172;
			case 173:
				return v173;
			case 174:
				return v174;
			case 175:
				return v175;
			case 176:
				return v176;
			case 177:
				return v177;
			case 178:
				return v178;
			case 179:
				return v179;
			case 180:
				return v180;
			case 181:
				return v181;
			case 182:
				return v182;
			case 183:
				return v183;
			case 184:
				return v184;
			case 185:
				return v185;
			case 186:
				return v186;
			case 187:
				return v187;
			case 188:
				return v188;
			case 189:
				return v189;
			case 190:
				return v190;
			case 191:
				return v191;
			case 192:
				return v192;
			case 193:
				return v193;
			case 194:
				return v194;
			case 195:
				return v195;
			case 196:
				return v196;
			case 197:
				return v197;
			case 198:
				return v198;
			case 199:
				return v199;
			case 200:
				return v200;
			case 201:
				return v201;
			case 202:
				return v202;
			case 203:
				return v203;
			case 204:
				return v204;
			case 205:
				return v205;
			case 206:
				return v206;
			case 207:
				return v207;
			case 208:
				return v208;
			case 209:
				return v209;
			case 210:
				return v210;
			case 211:
				return v211;
			case 212:
				return v212;
			case 213:
				return v213;
			case 214:
				return v214;
			case 215:
				return v215;
			case 216:
				return v216;
			case 217:
				return v217;
			case 218:
				return v218;
			case 219:
				return v219;
			case 220:
				return v220;
			case 221:
				return v221;
			case 222:
				return v222;
			case 223:
				return v223;
			case 224:
				return v224;
			case 225:
				return v225;
			case 226:
				return v226;
			case 227:
				return v227;
			case 228:
				return v228;
			case 229:
				return v229;
			case 230:
				return v230;
			case 231:
				return v231;
			case 232:
				return v232;
			case 233:
				return v233;
			case 234:
				return v234;
			case 235:
				return v235;
			case 236:
				return v236;
			case 237:
				return v237;
			case 238:
				return v238;
			case 239:
				return v239;
			case 240:
				return v240;
			case 241:
				return v241;
			case 242:
				return v242;
			case 243:
				return v243;
			case 244:
				return v244;
			case 245:
				return v245;
			case 246:
				return v246;
			case 247:
				return v247;
			case 248:
				return v248;
			case 249:
				return v249;
			case 250:
				return v250;
			case 251:
				return v251;
			case 252:
				return v252;
			case 253:
				return v253;
			case 254:
				return v254;
			case 255:
				return v255;
			default:
				return default(PointInfo);
			}
		}

		public void setValueByIndex(int PLCFEOMGCFK, PointInfo EDDNOJDPMCF)
		{
			switch (PLCFEOMGCFK)
			{
			case 0:
				v000 = EDDNOJDPMCF;
				break;
			case 1:
				v001 = EDDNOJDPMCF;
				break;
			case 2:
				v002 = EDDNOJDPMCF;
				break;
			case 3:
				v003 = EDDNOJDPMCF;
				break;
			case 4:
				v004 = EDDNOJDPMCF;
				break;
			case 5:
				v005 = EDDNOJDPMCF;
				break;
			case 6:
				v006 = EDDNOJDPMCF;
				break;
			case 7:
				v007 = EDDNOJDPMCF;
				break;
			case 8:
				v008 = EDDNOJDPMCF;
				break;
			case 9:
				v009 = EDDNOJDPMCF;
				break;
			case 10:
				v010 = EDDNOJDPMCF;
				break;
			case 11:
				v011 = EDDNOJDPMCF;
				break;
			case 12:
				v012 = EDDNOJDPMCF;
				break;
			case 13:
				v013 = EDDNOJDPMCF;
				break;
			case 14:
				v014 = EDDNOJDPMCF;
				break;
			case 15:
				v015 = EDDNOJDPMCF;
				break;
			case 16:
				v016 = EDDNOJDPMCF;
				break;
			case 17:
				v017 = EDDNOJDPMCF;
				break;
			case 18:
				v018 = EDDNOJDPMCF;
				break;
			case 19:
				v019 = EDDNOJDPMCF;
				break;
			case 20:
				v020 = EDDNOJDPMCF;
				break;
			case 21:
				v021 = EDDNOJDPMCF;
				break;
			case 22:
				v022 = EDDNOJDPMCF;
				break;
			case 23:
				v023 = EDDNOJDPMCF;
				break;
			case 24:
				v024 = EDDNOJDPMCF;
				break;
			case 25:
				v025 = EDDNOJDPMCF;
				break;
			case 26:
				v026 = EDDNOJDPMCF;
				break;
			case 27:
				v027 = EDDNOJDPMCF;
				break;
			case 28:
				v028 = EDDNOJDPMCF;
				break;
			case 29:
				v029 = EDDNOJDPMCF;
				break;
			case 30:
				v030 = EDDNOJDPMCF;
				break;
			case 31:
				v031 = EDDNOJDPMCF;
				break;
			case 32:
				v032 = EDDNOJDPMCF;
				break;
			case 33:
				v033 = EDDNOJDPMCF;
				break;
			case 34:
				v034 = EDDNOJDPMCF;
				break;
			case 35:
				v035 = EDDNOJDPMCF;
				break;
			case 36:
				v036 = EDDNOJDPMCF;
				break;
			case 37:
				v037 = EDDNOJDPMCF;
				break;
			case 38:
				v038 = EDDNOJDPMCF;
				break;
			case 39:
				v039 = EDDNOJDPMCF;
				break;
			case 40:
				v040 = EDDNOJDPMCF;
				break;
			case 41:
				v041 = EDDNOJDPMCF;
				break;
			case 42:
				v042 = EDDNOJDPMCF;
				break;
			case 43:
				v043 = EDDNOJDPMCF;
				break;
			case 44:
				v044 = EDDNOJDPMCF;
				break;
			case 45:
				v045 = EDDNOJDPMCF;
				break;
			case 46:
				v046 = EDDNOJDPMCF;
				break;
			case 47:
				v047 = EDDNOJDPMCF;
				break;
			case 48:
				v048 = EDDNOJDPMCF;
				break;
			case 49:
				v049 = EDDNOJDPMCF;
				break;
			case 50:
				v050 = EDDNOJDPMCF;
				break;
			case 51:
				v051 = EDDNOJDPMCF;
				break;
			case 52:
				v052 = EDDNOJDPMCF;
				break;
			case 53:
				v053 = EDDNOJDPMCF;
				break;
			case 54:
				v054 = EDDNOJDPMCF;
				break;
			case 55:
				v055 = EDDNOJDPMCF;
				break;
			case 56:
				v056 = EDDNOJDPMCF;
				break;
			case 57:
				v057 = EDDNOJDPMCF;
				break;
			case 58:
				v058 = EDDNOJDPMCF;
				break;
			case 59:
				v059 = EDDNOJDPMCF;
				break;
			case 60:
				v060 = EDDNOJDPMCF;
				break;
			case 61:
				v061 = EDDNOJDPMCF;
				break;
			case 62:
				v062 = EDDNOJDPMCF;
				break;
			case 63:
				v063 = EDDNOJDPMCF;
				break;
			case 64:
				v064 = EDDNOJDPMCF;
				break;
			case 65:
				v065 = EDDNOJDPMCF;
				break;
			case 66:
				v066 = EDDNOJDPMCF;
				break;
			case 67:
				v067 = EDDNOJDPMCF;
				break;
			case 68:
				v068 = EDDNOJDPMCF;
				break;
			case 69:
				v069 = EDDNOJDPMCF;
				break;
			case 70:
				v070 = EDDNOJDPMCF;
				break;
			case 71:
				v071 = EDDNOJDPMCF;
				break;
			case 72:
				v072 = EDDNOJDPMCF;
				break;
			case 73:
				v073 = EDDNOJDPMCF;
				break;
			case 74:
				v074 = EDDNOJDPMCF;
				break;
			case 75:
				v075 = EDDNOJDPMCF;
				break;
			case 76:
				v076 = EDDNOJDPMCF;
				break;
			case 77:
				v077 = EDDNOJDPMCF;
				break;
			case 78:
				v078 = EDDNOJDPMCF;
				break;
			case 79:
				v079 = EDDNOJDPMCF;
				break;
			case 80:
				v080 = EDDNOJDPMCF;
				break;
			case 81:
				v081 = EDDNOJDPMCF;
				break;
			case 82:
				v082 = EDDNOJDPMCF;
				break;
			case 83:
				v083 = EDDNOJDPMCF;
				break;
			case 84:
				v084 = EDDNOJDPMCF;
				break;
			case 85:
				v085 = EDDNOJDPMCF;
				break;
			case 86:
				v086 = EDDNOJDPMCF;
				break;
			case 87:
				v087 = EDDNOJDPMCF;
				break;
			case 88:
				v088 = EDDNOJDPMCF;
				break;
			case 89:
				v089 = EDDNOJDPMCF;
				break;
			case 90:
				v090 = EDDNOJDPMCF;
				break;
			case 91:
				v091 = EDDNOJDPMCF;
				break;
			case 92:
				v092 = EDDNOJDPMCF;
				break;
			case 93:
				v093 = EDDNOJDPMCF;
				break;
			case 94:
				v094 = EDDNOJDPMCF;
				break;
			case 95:
				v095 = EDDNOJDPMCF;
				break;
			case 96:
				v096 = EDDNOJDPMCF;
				break;
			case 97:
				v097 = EDDNOJDPMCF;
				break;
			case 98:
				v098 = EDDNOJDPMCF;
				break;
			case 99:
				v099 = EDDNOJDPMCF;
				break;
			case 100:
				v100 = EDDNOJDPMCF;
				break;
			case 101:
				v101 = EDDNOJDPMCF;
				break;
			case 102:
				v102 = EDDNOJDPMCF;
				break;
			case 103:
				v103 = EDDNOJDPMCF;
				break;
			case 104:
				v104 = EDDNOJDPMCF;
				break;
			case 105:
				v105 = EDDNOJDPMCF;
				break;
			case 106:
				v106 = EDDNOJDPMCF;
				break;
			case 107:
				v107 = EDDNOJDPMCF;
				break;
			case 108:
				v108 = EDDNOJDPMCF;
				break;
			case 109:
				v109 = EDDNOJDPMCF;
				break;
			case 110:
				v110 = EDDNOJDPMCF;
				break;
			case 111:
				v111 = EDDNOJDPMCF;
				break;
			case 112:
				v112 = EDDNOJDPMCF;
				break;
			case 113:
				v113 = EDDNOJDPMCF;
				break;
			case 114:
				v114 = EDDNOJDPMCF;
				break;
			case 115:
				v115 = EDDNOJDPMCF;
				break;
			case 116:
				v116 = EDDNOJDPMCF;
				break;
			case 117:
				v117 = EDDNOJDPMCF;
				break;
			case 118:
				v118 = EDDNOJDPMCF;
				break;
			case 119:
				v119 = EDDNOJDPMCF;
				break;
			case 120:
				v120 = EDDNOJDPMCF;
				break;
			case 121:
				v121 = EDDNOJDPMCF;
				break;
			case 122:
				v122 = EDDNOJDPMCF;
				break;
			case 123:
				v123 = EDDNOJDPMCF;
				break;
			case 124:
				v124 = EDDNOJDPMCF;
				break;
			case 125:
				v125 = EDDNOJDPMCF;
				break;
			case 126:
				v126 = EDDNOJDPMCF;
				break;
			case 127:
				v127 = EDDNOJDPMCF;
				break;
			case 128:
				v128 = EDDNOJDPMCF;
				break;
			case 129:
				v129 = EDDNOJDPMCF;
				break;
			case 130:
				v130 = EDDNOJDPMCF;
				break;
			case 131:
				v131 = EDDNOJDPMCF;
				break;
			case 132:
				v132 = EDDNOJDPMCF;
				break;
			case 133:
				v133 = EDDNOJDPMCF;
				break;
			case 134:
				v134 = EDDNOJDPMCF;
				break;
			case 135:
				v135 = EDDNOJDPMCF;
				break;
			case 136:
				v136 = EDDNOJDPMCF;
				break;
			case 137:
				v137 = EDDNOJDPMCF;
				break;
			case 138:
				v138 = EDDNOJDPMCF;
				break;
			case 139:
				v139 = EDDNOJDPMCF;
				break;
			case 140:
				v140 = EDDNOJDPMCF;
				break;
			case 141:
				v141 = EDDNOJDPMCF;
				break;
			case 142:
				v142 = EDDNOJDPMCF;
				break;
			case 143:
				v143 = EDDNOJDPMCF;
				break;
			case 144:
				v144 = EDDNOJDPMCF;
				break;
			case 145:
				v145 = EDDNOJDPMCF;
				break;
			case 146:
				v146 = EDDNOJDPMCF;
				break;
			case 147:
				v147 = EDDNOJDPMCF;
				break;
			case 148:
				v148 = EDDNOJDPMCF;
				break;
			case 149:
				v149 = EDDNOJDPMCF;
				break;
			case 150:
				v150 = EDDNOJDPMCF;
				break;
			case 151:
				v151 = EDDNOJDPMCF;
				break;
			case 152:
				v152 = EDDNOJDPMCF;
				break;
			case 153:
				v153 = EDDNOJDPMCF;
				break;
			case 154:
				v154 = EDDNOJDPMCF;
				break;
			case 155:
				v155 = EDDNOJDPMCF;
				break;
			case 156:
				v156 = EDDNOJDPMCF;
				break;
			case 157:
				v157 = EDDNOJDPMCF;
				break;
			case 158:
				v158 = EDDNOJDPMCF;
				break;
			case 159:
				v159 = EDDNOJDPMCF;
				break;
			case 160:
				v160 = EDDNOJDPMCF;
				break;
			case 161:
				v161 = EDDNOJDPMCF;
				break;
			case 162:
				v162 = EDDNOJDPMCF;
				break;
			case 163:
				v163 = EDDNOJDPMCF;
				break;
			case 164:
				v164 = EDDNOJDPMCF;
				break;
			case 165:
				v165 = EDDNOJDPMCF;
				break;
			case 166:
				v166 = EDDNOJDPMCF;
				break;
			case 167:
				v167 = EDDNOJDPMCF;
				break;
			case 168:
				v168 = EDDNOJDPMCF;
				break;
			case 169:
				v169 = EDDNOJDPMCF;
				break;
			case 170:
				v170 = EDDNOJDPMCF;
				break;
			case 171:
				v171 = EDDNOJDPMCF;
				break;
			case 172:
				v172 = EDDNOJDPMCF;
				break;
			case 173:
				v173 = EDDNOJDPMCF;
				break;
			case 174:
				v174 = EDDNOJDPMCF;
				break;
			case 175:
				v175 = EDDNOJDPMCF;
				break;
			case 176:
				v176 = EDDNOJDPMCF;
				break;
			case 177:
				v177 = EDDNOJDPMCF;
				break;
			case 178:
				v178 = EDDNOJDPMCF;
				break;
			case 179:
				v179 = EDDNOJDPMCF;
				break;
			case 180:
				v180 = EDDNOJDPMCF;
				break;
			case 181:
				v181 = EDDNOJDPMCF;
				break;
			case 182:
				v182 = EDDNOJDPMCF;
				break;
			case 183:
				v183 = EDDNOJDPMCF;
				break;
			case 184:
				v184 = EDDNOJDPMCF;
				break;
			case 185:
				v185 = EDDNOJDPMCF;
				break;
			case 186:
				v186 = EDDNOJDPMCF;
				break;
			case 187:
				v187 = EDDNOJDPMCF;
				break;
			case 188:
				v188 = EDDNOJDPMCF;
				break;
			case 189:
				v189 = EDDNOJDPMCF;
				break;
			case 190:
				v190 = EDDNOJDPMCF;
				break;
			case 191:
				v191 = EDDNOJDPMCF;
				break;
			case 192:
				v192 = EDDNOJDPMCF;
				break;
			case 193:
				v193 = EDDNOJDPMCF;
				break;
			case 194:
				v194 = EDDNOJDPMCF;
				break;
			case 195:
				v195 = EDDNOJDPMCF;
				break;
			case 196:
				v196 = EDDNOJDPMCF;
				break;
			case 197:
				v197 = EDDNOJDPMCF;
				break;
			case 198:
				v198 = EDDNOJDPMCF;
				break;
			case 199:
				v199 = EDDNOJDPMCF;
				break;
			case 200:
				v200 = EDDNOJDPMCF;
				break;
			case 201:
				v201 = EDDNOJDPMCF;
				break;
			case 202:
				v202 = EDDNOJDPMCF;
				break;
			case 203:
				v203 = EDDNOJDPMCF;
				break;
			case 204:
				v204 = EDDNOJDPMCF;
				break;
			case 205:
				v205 = EDDNOJDPMCF;
				break;
			case 206:
				v206 = EDDNOJDPMCF;
				break;
			case 207:
				v207 = EDDNOJDPMCF;
				break;
			case 208:
				v208 = EDDNOJDPMCF;
				break;
			case 209:
				v209 = EDDNOJDPMCF;
				break;
			case 210:
				v210 = EDDNOJDPMCF;
				break;
			case 211:
				v211 = EDDNOJDPMCF;
				break;
			case 212:
				v212 = EDDNOJDPMCF;
				break;
			case 213:
				v213 = EDDNOJDPMCF;
				break;
			case 214:
				v214 = EDDNOJDPMCF;
				break;
			case 215:
				v215 = EDDNOJDPMCF;
				break;
			case 216:
				v216 = EDDNOJDPMCF;
				break;
			case 217:
				v217 = EDDNOJDPMCF;
				break;
			case 218:
				v218 = EDDNOJDPMCF;
				break;
			case 219:
				v219 = EDDNOJDPMCF;
				break;
			case 220:
				v220 = EDDNOJDPMCF;
				break;
			case 221:
				v221 = EDDNOJDPMCF;
				break;
			case 222:
				v222 = EDDNOJDPMCF;
				break;
			case 223:
				v223 = EDDNOJDPMCF;
				break;
			case 224:
				v224 = EDDNOJDPMCF;
				break;
			case 225:
				v225 = EDDNOJDPMCF;
				break;
			case 226:
				v226 = EDDNOJDPMCF;
				break;
			case 227:
				v227 = EDDNOJDPMCF;
				break;
			case 228:
				v228 = EDDNOJDPMCF;
				break;
			case 229:
				v229 = EDDNOJDPMCF;
				break;
			case 230:
				v230 = EDDNOJDPMCF;
				break;
			case 231:
				v231 = EDDNOJDPMCF;
				break;
			case 232:
				v232 = EDDNOJDPMCF;
				break;
			case 233:
				v233 = EDDNOJDPMCF;
				break;
			case 234:
				v234 = EDDNOJDPMCF;
				break;
			case 235:
				v235 = EDDNOJDPMCF;
				break;
			case 236:
				v236 = EDDNOJDPMCF;
				break;
			case 237:
				v237 = EDDNOJDPMCF;
				break;
			case 238:
				v238 = EDDNOJDPMCF;
				break;
			case 239:
				v239 = EDDNOJDPMCF;
				break;
			case 240:
				v240 = EDDNOJDPMCF;
				break;
			case 241:
				v241 = EDDNOJDPMCF;
				break;
			case 242:
				v242 = EDDNOJDPMCF;
				break;
			case 243:
				v243 = EDDNOJDPMCF;
				break;
			case 244:
				v244 = EDDNOJDPMCF;
				break;
			case 245:
				v245 = EDDNOJDPMCF;
				break;
			case 246:
				v246 = EDDNOJDPMCF;
				break;
			case 247:
				v247 = EDDNOJDPMCF;
				break;
			case 248:
				v248 = EDDNOJDPMCF;
				break;
			case 249:
				v249 = EDDNOJDPMCF;
				break;
			case 250:
				v250 = EDDNOJDPMCF;
				break;
			case 251:
				v251 = EDDNOJDPMCF;
				break;
			case 252:
				v252 = EDDNOJDPMCF;
				break;
			case 253:
				v253 = EDDNOJDPMCF;
				break;
			case 254:
				v254 = EDDNOJDPMCF;
				break;
			case 255:
				v255 = EDDNOJDPMCF;
				break;
			}
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			base.OnAfterDeserialize();
			for (int i = 0; i < 256; i++)
			{
				if (serelizateAnimationPoints[i] != -1 && serelizateAnimationPoints[i] < base.JJJGMPMMJIN.Count)
				{
					animationPoints[i] = base.JJJGMPMMJIN[serelizateAnimationPoints[i]];
				}
			}
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
			OnBeforeSerialize();
			for (int i = 0; i < 256; i++)
			{
				if (animationPoints[i] != null && base.JJJGMPMMJIN.Contains(animationPoints[i]))
				{
					serelizateAnimationPoints[i] = base.JJJGMPMMJIN.IndexOf(animationPoints[i]);
				}
				else
				{
					serelizateAnimationPoints[i] = -1;
				}
			}
		}
	}
}
